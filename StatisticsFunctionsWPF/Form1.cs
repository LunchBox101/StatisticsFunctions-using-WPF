﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using StatisticsFunctionsWPF;

namespace StatisticsFunctionsWPF
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            this.chart1.Series.Clear();
            this.chart1.Titles.Add("Numbers");
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int numberOfNumbers;
            double percentOfDiscardNumbers = 0.0;
            valuesListBox.Items.Clear();
            sortedListBox.Items.Clear();
            try
            {
                if (int.TryParse(valuesTextBox.Text, out numberOfNumbers))
                {
                    if (int.TryParse(disFractionTextBox.Text, out int numberOfDiscardNumbers) || double.TryParse(disFractionTextBox.Text, out percentOfDiscardNumbers))
                    {
                        this.chart1.Series.Clear();
                        int[] arrayValues = new int[numberOfNumbers];
                        List<int> listValues = new List<int>();
                        SortedDictionary<int, int> graphDictionary = new SortedDictionary<int, int>();

                        for (int loop = 0; loop < numberOfNumbers; loop++)
                        {
                            int number = ran.Next(1, 6) + ran.Next(1, 6);

                            arrayValues[loop] = number;
                            listValues.Add(number);

                            if (graphDictionary.ContainsKey(number))
                            {
                                int tempNumber = graphDictionary[number];
                                graphDictionary[number] = tempNumber += 1;
                            }
                            else
                            {
                                graphDictionary.Add(number, 1);
                            }
                        }
                        fillGraph(ref graphDictionary);
                        valueFiller(ref arrayValues, ref listValues, numberOfDiscardNumbers, percentOfDiscardNumbers);
                    }
                    else
                    {
                        throw new Exception("a correct number was not entered in the discard value");
                    }
                }
                else
                {
                    throw new Exception("What you have entered is not a number");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                disFractionTextBox.Text = "0";
                valuesTextBox.Text = null;
            }
        }

        private void chart1_Load(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            this.chart1.Palette = ChartColorPalette.EarthTones;
        }

        private void valueFiller(ref int[] valuesArray, ref List<int> valuesList, int discardedValue, double discardedValuePercent)
        {
            fillValueListBox(valuesArray);
            fillSortedListBox(valuesArray);
            miniArrayLabel.Text = StatisticExtension.MinValue(valuesArray).ToString();
            listMiniLabel.Text = StatisticExtension.MinValue(valuesList).ToString();
            arrayMaxLabel.Text = StatisticExtension.MaxValue(valuesArray).ToString();
            ListMaxLabel.Text = StatisticExtension.MaxValue(valuesList).ToString();
            arrayMeanLabel.Text = StatisticExtension.MeanValue(valuesArray).ToString();
            listMeanLabel.Text = StatisticExtension.MeanValue(valuesList).ToString();
            if(discardedValue == 0 && discardedValuePercent != 0)
            {
                arrayTrunMeanLabel.Text = StatisticExtension.TrunMeanValue(valuesArray, discardedValuePercent).ToString();
                listTrunMeanLabel.Text = StatisticExtension.TrunMeanValue(valuesList, discardedValuePercent).ToString();
            }
            else
            {
                arrayTrunMeanLabel.Text = StatisticExtension.TrunMeanValue(valuesArray, discardedValue).ToString();
                listTrunMeanLabel.Text = StatisticExtension.TrunMeanValue(valuesList, discardedValue).ToString();
            }
            
        }




        private void fillGraph(ref SortedDictionary<int, int> graphDictionary)
        {
            foreach(KeyValuePair<int, int> singleCell in graphDictionary)
            {
                Series series = this.chart1.Series.Add(singleCell.Key.ToString());
                series.Points.Add(singleCell.Value);
            }
        }

        private void fillValueListBox(int[] values)
        {
            for(int loop = 0; loop < values.Length; loop++)
            {
                valuesListBox.Items.Add(values[loop].ToString());
            }
        }

        private void fillSortedListBox(int[] values)
        {
            Array.Sort(values);
            for (int loop = 0; loop < values.Length; loop++)
            {
                sortedListBox.Items.Add(values[loop].ToString());
            }
        }
    }
}
