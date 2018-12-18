using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Xamarin.Forms;

namespace ATicket.ViewModels
{
    public class CalculatorModel : BaseViewModel
    {
        string x = "0";
        string y = "0";
        string cal = "";
        string first = "";
        string second = "";
        string result = "0";
        public CalculatorModel()
        {
            //清除 C 键
            ClearCommand = new Command(
                execute: () =>
                {
                    X = "0";
                    Y = "0";
                    Cal = "";
                    first = "";
                    Result = "0";
                });

            //数字键
            DigitCommand = new Command<string>(
                execute: (string arg) =>
                {
                    if (first == "")
                    {
                        if (X.StartsWith("0") && !X.StartsWith("0."))
                        {
                            X = X.Substring(1);
                        }
                        X += arg;
                    }
                    else
                    {
                        if (Y.StartsWith("0") && !Y.StartsWith("0."))
                        {
                            Y = Y.Substring(1);
                        }
                        Y += arg;
                    }
                },
                canExecute: (string arg) =>
                {
                    return !(arg == ".");
                });

            //运算键
            FunctionCommand = new Command<string>(
                 execute: (string arg) =>
                 {
                     if (Result != "0" && Result != "")
                     {
                         //把result 传给 first
                         X = Result;
                         first = X;
                         Cal = arg;
                         //Clear 功能
                         Y = "0";
                         Result = "0";

                         
                     }

                     if (X != "" && !X.StartsWith("0"))
                     {
                         first = X;
                         Cal = arg;
                     }
                 });

            //等于 Enter 键
            EnterCommand = new Command(
                execute: () =>
                {
                    if (first != "" && Y != "" && !Y.StartsWith("0"))
                    {
                        double temp;
                        temp = fun(Convert.ToDouble(first), Convert.ToDouble(Y), Cal);
                        Result = temp.ToString();
                    }
                    else
                    {
                        Result = "数学算式超出规划";
                    }
                });
        }


        public ICommand ClearCommand { private set; get; }

        public ICommand DigitCommand { private set; get; }

        public ICommand EnterCommand { private set; get; }

        public ICommand FunctionCommand { private set; get; }

        //public string Entry
        //{
        //    set
        //    {
        //        entry = value;
        //        OnPropertyChanged();
        //    }
        //    get { return entry; }
        //}

        public string Result
        {
            set
            {
                result = value;
                OnPropertyChanged();
            }
            get { return result; }
        }

        public string X
        {
            set
            {
                x = value;
                OnPropertyChanged();
            }
            get { return x; }
        }

        public string Y
        {
            set
            {
                y = value;
                OnPropertyChanged();
            }
            get { return y; }
        }

        public string Cal
        {
            set
            {
                cal = value;
                OnPropertyChanged();
            }
            get { return cal; }
        }

        private double fun(double x, double y, string c)
        {
            double result = 0;
            switch (c)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
                default:
                    break;
            }
            return result;
        }

    }
}
