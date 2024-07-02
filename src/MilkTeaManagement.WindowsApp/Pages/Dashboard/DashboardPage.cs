using Bogus;
using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Common.Models.Dashboard;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Repositories;
using MilkTeaManagement.WindowsApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MilkTeaManagement.WindowsApp.Pages.Dashboard
{
    public partial class DashboardPage : Page
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IProductsRepository _productsRepository;

        private List<OrderDBDTO> orders = new List<OrderDBDTO>();
        private List<OrderItem> orderItems = new List<OrderItem>();

        private Color defaultButtonColor = ColorTranslator.FromHtml("#777aca");
        private Color activeButtonColor = ColorTranslator.FromHtml("#5156be");
        private Button lastClickButton;

        public DashboardPage(IOrdersRepository ordersRepository, IProductsRepository productsRepository)
        {
            InitializeComponent();

            _ordersRepository = ordersRepository;
            _productsRepository = productsRepository;
        }

        public override async void OnLoad()
        {
            SetDefaultStyleForButtons();
            SetDefaultStyleForChartRevenue();
            
            orders = await _ordersRepository.GetAllOrders();
            orderItems = await _ordersRepository.GetAllOrderItems();

            LoadBestProduct();
            LoadThreeTotalPanels();

            var ordersGroupByDate = orders.GroupBy(o => o.CreatedDate.Date)
                .Select(g => new OrderDBDTO
                {
                    CreatedDate = g.Key,
                    TotalPrice = g.Sum(o => o.TotalPrice)
                })
                .OrderBy(o => o.CreatedDate)
                .ToList();

            LoadChartRevenue(ordersGroupByDate, 1);
        }

        private async void LoadBestProduct()
        {
            var bestSellerProductIDs = orderItems
                .GroupBy(item => item.ProductId)
                .Select(group => new
                {
                    ProductId = group.Key,
                    TotalQuantity = group.Sum(item => item.Quantity)
                })
                .OrderByDescending(result => result.TotalQuantity)
                .Take(2)
                .ToList();

            if (bestSellerProductIDs != null)
            {
                Product product1 = await _productsRepository.GetByIdAsync(bestSellerProductIDs[0].ProductId);
                if (product1 != null)
                {
                    pbProduct1.ImageLocation = product1.Poster;
                    pbProduct1.SizeMode = PictureBoxSizeMode.Zoom;
                    lbProductName1.Text = product1.Name;
                    lbQuantity1.Text = bestSellerProductIDs[0].TotalQuantity.ToString();
                }

                Product product2 = await _productsRepository.GetByIdAsync(bestSellerProductIDs[1].ProductId);
                if (product2 != null)
                {
                    pbProduct2.ImageLocation = product2.Poster;
                    pbProduct2.SizeMode = PictureBoxSizeMode.Zoom;
                    lbProductName2.Text = product2.Name;
                    lbQuantity2.Text = bestSellerProductIDs[1].TotalQuantity.ToString();
                }
            }
        }

        private void LoadThreeTotalPanels()
        {
            var totalOrders = orders.Count;
            lbTotalOrders.Text = totalOrders.ToString();

            var totalRevenue = orders.Sum(o => o.TotalPrice);
            lbTotalRevenue.Text = totalRevenue.ToString("C0");

            var totalProductsSold = orderItems.Sum(oi => oi.Quantity);
            lbTotalSold.Text = totalProductsSold.ToString();
        }

        private void SetDefaultStyleForButtons()
        {
            btnDay.BackColor = activeButtonColor;
            btnMonth.BackColor = defaultButtonColor;
            btnYear.BackColor = defaultButtonColor;
            lastClickButton = btnDay;
        }

        private void SetDefaultStyleForChartRevenue()
        {
            chartRevenue.Titles.Clear();
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();

            chartRevenue.ChartAreas.Add("MainChartArea");
            chartRevenue.ChartAreas["MainChartArea"].BackColor = ColorTranslator.FromHtml("#313533");

            chartRevenue.Titles.Add("Total Revenue");
            chartRevenue.Titles[0].Font = new Font("Segoe UI", 20, FontStyle.Bold);
            chartRevenue.Titles[0].ForeColor = ColorTranslator.FromHtml("#a8aada");

            chartRevenue.ChartAreas["MainChartArea"].AxisX.TitleFont = new Font("Segoe UI", 14, FontStyle.Bold);
            chartRevenue.ChartAreas["MainChartArea"].AxisX.TitleForeColor = ColorTranslator.FromHtml("#d1ced4");
            chartRevenue.ChartAreas["MainChartArea"].AxisX.LineColor = ColorTranslator.FromHtml("#666968");
            chartRevenue.ChartAreas["MainChartArea"].AxisX.LineWidth = 2;
            chartRevenue.ChartAreas["MainChartArea"].AxisX.MajorGrid.LineWidth = 0;
            chartRevenue.ChartAreas["MainChartArea"].AxisX.MajorTickMark.LineColor = ColorTranslator.FromHtml("#666968");
            chartRevenue.ChartAreas["MainChartArea"].AxisX.MajorTickMark.LineWidth = 2;
            chartRevenue.ChartAreas["MainChartArea"].AxisX.MajorTickMark.Size = 2;
            chartRevenue.ChartAreas["MainChartArea"].AxisX.LabelStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartRevenue.ChartAreas["MainChartArea"].AxisX.LabelStyle.ForeColor = ColorTranslator.FromHtml("#a8aada");

            chartRevenue.ChartAreas["MainChartArea"].AxisY.Title = "Total Revenue";
            chartRevenue.ChartAreas["MainChartArea"].AxisY.TitleFont = new Font("Segoe UI", 14, FontStyle.Bold);
            chartRevenue.ChartAreas["MainChartArea"].AxisY.TitleForeColor = ColorTranslator.FromHtml("#d1ced4");
            chartRevenue.ChartAreas["MainChartArea"].AxisY.LineColor = ColorTranslator.FromHtml("#666968");
            chartRevenue.ChartAreas["MainChartArea"].AxisY.LineWidth = 2;
            chartRevenue.ChartAreas["MainChartArea"].AxisY.MajorGrid.LineColor = ColorTranslator.FromHtml("#666968");
            chartRevenue.ChartAreas["MainChartArea"].AxisY.MajorTickMark.LineColor = ColorTranslator.FromHtml("#666968");
            chartRevenue.ChartAreas["MainChartArea"].AxisY.MajorTickMark.LineWidth = 0;
            chartRevenue.ChartAreas["MainChartArea"].AxisY.MajorTickMark.Size = 0;
            chartRevenue.ChartAreas["MainChartArea"].AxisY.LabelStyle.Format = "C0";
            chartRevenue.ChartAreas["MainChartArea"].AxisY.LabelStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartRevenue.ChartAreas["MainChartArea"].AxisY.LabelStyle.ForeColor = ColorTranslator.FromHtml("#a8aada");
        }

        private void LoadChartRevenue(List<OrderDBDTO> orders, int option)
        {
            SetDefaultStyleForChartRevenue();
            
            var series = new Series
            {
                Name = "Total Revenue",
                Color = ColorTranslator.FromHtml("#34c892"),
                ChartType = SeriesChartType.Column
            };

            if (option == 1)
            {
                chartRevenue.Titles[0].Text = "Total Revenue by Day";

                chartRevenue.ChartAreas["MainChartArea"].AxisX.Title = "Day";
                chartRevenue.ChartAreas["MainChartArea"].AxisX.LabelStyle.Format = "d/M";

                foreach (var order in orders)
                {
                    series.Points.AddXY(order.CreatedDate, order.TotalPrice);
                }

                chartRevenue.Series.Add(series);

                chartRevenue.Invalidate();
            }
            else if (option == 2)
            {
                chartRevenue.Titles[0].Text = "Total Revenue by Month";

                chartRevenue.ChartAreas["MainChartArea"].AxisX.Title = "Month";
                chartRevenue.ChartAreas["MainChartArea"].AxisX.LabelStyle.Format = "M/yyyy";

                chartRevenue.ChartAreas["MainChartArea"].AxisX.IntervalType = DateTimeIntervalType.Months;
                chartRevenue.ChartAreas["MainChartArea"].AxisX.Interval = 1;

                foreach (var order in orders)
                {
                    series.Points.AddXY(order.CreatedDate, order.TotalPrice);
                }

                chartRevenue.Series.Add(series);

                chartRevenue.Invalidate();
            }
            else
            {
                chartRevenue.Titles[0].Text = "Total Revenue by Year";

                chartRevenue.ChartAreas["MainChartArea"].AxisX.Title = "Year";

                foreach (var order in orders)
                {
                    series.Points.AddXY(order.CreatedDate.Year.ToString(), order.TotalPrice);
                }

                chartRevenue.Series.Add(series);

                chartRevenue.Invalidate();
            }
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            lastClickButton.BackColor = defaultButtonColor;
            btnDay.BackColor = activeButtonColor;
            lastClickButton = btnDay;

            var ordersGroupByDate = orders.GroupBy(o => o.CreatedDate.Date)
                .Select(g => new OrderDBDTO
                {
                    CreatedDate = g.Key,
                    TotalPrice = g.Sum(o => o.TotalPrice)
                })
                .OrderBy(o => o.CreatedDate)
                .ToList();

            LoadChartRevenue(ordersGroupByDate, 1);
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            lastClickButton.BackColor = defaultButtonColor;
            btnMonth.BackColor = activeButtonColor;
            lastClickButton = btnMonth;

            var ordersGroupByMonth = orders.GroupBy(o => new { Year = o.CreatedDate.Year, Month = o.CreatedDate.Month })
                .Select(g => new OrderDBDTO
                {
                    CreatedDate = new DateTime(g.Key.Year, g.Key.Month, 1),
                    TotalPrice = g.Sum(o => o.TotalPrice)
                })
                .OrderBy(o => o.CreatedDate)
                .ToList();

            LoadChartRevenue(ordersGroupByMonth, 2);
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            lastClickButton.BackColor = defaultButtonColor;
            btnYear.BackColor = activeButtonColor;
            lastClickButton = btnYear;

            var ordersGroupByYear = orders.GroupBy(o => o.CreatedDate.Year)
                .Select(g => new OrderDBDTO
                {
                    CreatedDate = new DateTime(g.Key, 1, 1),
                    TotalPrice = g.Sum(o => o.TotalPrice)
                })
                .OrderBy(o => o.CreatedDate)
                .ToList();

            LoadChartRevenue(ordersGroupByYear, 3);
        }
    }
}
