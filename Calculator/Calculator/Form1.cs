﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum State
    {
        WaitingForFirstNumber,
        WaitingForSecondNumber,
        WaitingForResult,
        WaitingForOperation
    }


    public partial class Form1 : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        string operation = "";
        double memoryNumber = 0;
        State state;

        public Form1()
        {
            InitializeComponent();
            state = State.WaitingForFirstNumber;
        }

        private void pad_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
                display.Clear();

            Button btn = sender as Button;

            switch (state)
            {
                case State.WaitingForFirstNumber:
                    state = State.WaitingForOperation;
                    break;
                case State.WaitingForSecondNumber:
                    state = State.WaitingForResult;
                    display.Text = "";
                    break;
            }

            if (btn.Text == ".")
            {
                if (!display.Text.Contains("."))
                    display.Text += btn.Text;
            }
            else
                display.Text += btn.Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            firstNumber = double.Parse(display.Text);
            state = State.WaitingForSecondNumber;
            operation = btn.Text;
        }

        private void operationResult_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(display.Text);

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
            }

            display.Text = result.ToString();
            firstNumber = result;
        }

        private void operationResultSpecial_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(display.Text);
            Button operationTypeButton = sender as Button;
            string operationType = operationTypeButton.Text;
            switch (operationType)
            {
                case "sqrt":
                    secondNumber = Math.Sqrt(secondNumber);
                    break;
                case "%":
                    switch (operation)
                    {
                        case "+":
                            result = firstNumber + (firstNumber / 100.0) * secondNumber;
                            break;
                        case "-":
                            result = firstNumber - (firstNumber / 100.0) * secondNumber;
                            break;
                        case "/":
                            result = (firstNumber / secondNumber) * 100.0;
                            break;
                        case "*":
                            result = (firstNumber / 100.0) * secondNumber;
                            break;
                    }
                    break;
                case "1/x":
                    result = 1 / secondNumber;
                    break;
            }
            display.Text = result.ToString();
            //убрать из памяти operation, secondNumber должен стать firstNumber
            //недоработка
            firstNumber = result;
            state = State.WaitingForSecondNumber;
        }

        private void operationClear_Click(object sender, EventArgs e)
        {
            Button operationClearButton = sender as Button;
            string operationClear = operationClearButton.Text;

            switch (operationClear)
            {
                case "C":
                    display.Text = "0";
                    result = 0;
                    secondNumber = 0;
                    firstNumber = 0;
                    break;
                case "CE":
                    display.Text = "0";
                    break;
            }
        }

        private void operationMemory_Click(object sender, EventArgs e)
        {
            Button operationMemoryButton = sender as Button;
            string operationMemory = operationMemoryButton.Text;

            switch (operationMemory)
            {
                case "MC":
                    memoryNumber = 0;
                    break;
                case "MR":
                    display.Text = memoryNumber.ToString();
                    break;
                case "MS":
                    memoryNumber = double.Parse(display.Text);
                    break;
                case "M+":
                    memoryNumber = memoryNumber + Double.Parse(display.Text);
                    break;
            }
            memory.Text = memoryNumber.ToString();
        }
    }
}
