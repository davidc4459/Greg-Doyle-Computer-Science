using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e) {} 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {}
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {}
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e) {}


        private void testbtn_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (comboBox1.SelectedItem.ToString().Equals("100"))
            {
                foreach (int indexChecked1 in checkedListBox1.CheckedIndices)//new
                {
                    if (checkedListBox1.Items[indexChecked1].ToString() == "Java")//new
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)//new
                        {

                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")//new
                            {
                                try
                                {
                                    
                                    
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\100\runHeapsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }


                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")//new
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\100\runInsertionsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\100\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\100\runQuicksort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                    if (checkedListBox1.Items[indexChecked1].ToString() == "C++")
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)//new
                        {

                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\100\runHeapsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\100\runInsertionsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\100\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\100\runQuicksort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                    if (checkedListBox1.Items[indexChecked1].ToString() == "Python")
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)
                        {
                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\100\runHeapSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\100\runInsertionSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\100\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\100\runQuickSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.SelectedItem.ToString().Equals("1000"))
            {
                foreach (int indexChecked1 in checkedListBox1.CheckedIndices)//new
                {
                    if (checkedListBox1.Items[indexChecked1].ToString() == "Java")//new
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)//new
                        {

                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")//new
                            {
                                try
                                {

                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\1000\runHeapsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }


                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")//new
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\1000\runInsertionsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\1000\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\1000\runQuicksort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                    if (checkedListBox1.Items[indexChecked1].ToString() == "C++")
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)//new
                        {

                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\1000\runHeapsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\1000\runInsertionsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\1000\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\1000\runQuicksort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                    if (checkedListBox1.Items[indexChecked1].ToString() == "Python")
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)
                        {
                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\1000\runHeapSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\1000\runInsertionSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\1000\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\1000\runQuickSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.SelectedItem.ToString().Equals("10000"))
            {
                foreach (int indexChecked1 in checkedListBox1.CheckedIndices)//new
                {
                    if (checkedListBox1.Items[indexChecked1].ToString() == "Java")//new
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)//new
                        {

                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")//new
                            {
                                try
                                {

                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\10000\runHeapsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }


                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")//new
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\10000\runInsertionsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\10000\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\10000\runQuicksort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                    if (checkedListBox1.Items[indexChecked1].ToString() == "C++")
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)//new
                        {

                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\10000\runHeapsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\10000\runInsertionsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\10000\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\10000\runQuicksort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                    if (checkedListBox1.Items[indexChecked1].ToString() == "Python")
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)
                        {
                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\10000\runHeapSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\10000\runInsertionSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\10000\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\10000\runQuickSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.SelectedItem.ToString().Equals("100000"))
            {
                foreach (int indexChecked1 in checkedListBox1.CheckedIndices)//new
                {
                    if (checkedListBox1.Items[indexChecked1].ToString() == "Java")//new
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)//new
                        {

                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")//new
                            {
                                try
                                {

                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\100000\runHeapsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }


                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")//new
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\100000\runInsertionsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\100000\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Java Algorithms\100000\runQuicksort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                    if (checkedListBox1.Items[indexChecked1].ToString() == "C++")
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)//new
                        {

                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\100000\runHeapsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\100000\runInsertionsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\100000\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\C++ Algorithms\C++EXE\100000\runQuicksort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                    if (checkedListBox1.Items[indexChecked1].ToString() == "Python")
                    {
                        foreach (int indexChecked2 in checkedListBox2.CheckedIndices)
                        {
                            if (checkedListBox2.Items[indexChecked2].ToString() == "HeapSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\100000\runHeapSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "InsertionSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\100000\runInsertionSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "ShellSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\100000\runShellsort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                            if (checkedListBox2.Items[indexChecked2].ToString() == "QuickSort")
                            {
                                try
                                {
                                    Process firstProc = new Process();
                                    firstProc.StartInfo.FileName = @"C:\Algorithms\Python Algorithms\100000\runQuickSort.bat";
                                    firstProc.EnableRaisingEvents = true;
                                    firstProc.Start();
                                }
                                catch (Exception ex)
                                { }
                            }
                        }
                    }
                }
            }
        }

     

    }
}