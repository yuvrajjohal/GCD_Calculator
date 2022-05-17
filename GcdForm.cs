using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuclideanGcdVersusBruteForceGcd
{
    public partial class GcdForm : Form
    {
        #region Fields (Global Variables)

        // Used to allow easy enabling/disabling of the 4 gcd buttons.
        private readonly Button[] gcdButton = new Button[4];

        #endregion

        #region Constructor Method
        public GcdForm()
        {
            InitializeComponent();

            GcdLabel.Text = "";
            ExecutionTimeLabel.Text = "";

            // Load references to gcd buttons into the array 'gcdButton'
            gcdButton[0] = EuclideanGcdOverload1Button;
            gcdButton[1] = BruteForceGcdOverload1Button;
            gcdButton[2] = EuclideanGcdOverload2Button;
            gcdButton[3] = BruteForceGcdOverload2Button;
        }
        #endregion

        #region Methods for Computing GCD
        // 'EuclideanGcd' Overload 1:
        // Uses the Euclidean algorithm to compute the greatest common divisor of 'm' and 'n'
        // int m, int n, returns int

        private static int EuclideanGcd(int m, int n)
        {
            // gcd(0, 0) is undefined -> indicated by returning -1 since gcd(m, n) >= 0
            int gcd = -1;

            if (m != 0 && n != 0)
            {
                // Algorithm only works if m>=0 and n>=0. (gcd(m, n) = gcd(|m|, |n|).)
                m = Math.Abs(m);
                n = Math.Abs(n);

                do
                {
                    int remainder = m % n;
                    m = n;
                    n = remainder;
                } while (n > 0);

                gcd = m;
            }

            return gcd; //Keep in mind that the best practice is to have one 'return' at the end.
        }

        // 'EuclideanGcd' Overload 2:
        // Uses the Euclidean algorithm to compute the greatest common divisor of 'm' and 'n'
        // long m, long n, returns long

        private static long EuclideanGcd(long m, long n)
        {
            // gcd(0, 0) is undefined -> indicated by returning -1 since gcd(m, n) >= 0
            long gcd = -1;

            if (m != 0 && n != 0)
            {
                // Algorithm only works if m>=0 and n>=0. (gcd(m, n) = gcd(|m|, |n|).)
                m = Math.Abs(m);
                n = Math.Abs(n);

                do
                {
                    long remainder = m % n;
                    m = n;
                    n = remainder;
                } while (n > 0);

                gcd = m;
            }

            return gcd; 
        }

        // 'BruteForceGcd' Overload 1:
        // Uses exhaustive search to compute the greatest common divisor of 'm' and 'n'
        // int m, int n, returns int
        // 'BackgroundWorker' component needed because 'BruteForceGCD' is very slow when 'm' and 'n' are large.

        private static int BruteForceGcd(int m, int n, BackgroundWorker gcdBackgroundWorker)
        {
            // gcd(0, 0) is undefined -> indicated by returning -1 since gcd(m, n) >= 0
            int gcd = -1;

            if (m != 0 && n != 0)
            {
                gcd = 1; // If no common divisor > 1 is found, gcd must equal 1.

                // Algorithm only works if m >= 0 and n >= 0. (gcd(m, n) = gcd(|m|, |n|).)
                m = Math.Abs(m);
                n = Math.Abs(n);

                int smaller = Math.Min(m, n);

                for (int i = smaller; i >= 2 && !gcdBackgroundWorker.CancellationPending; i--)
                {
                    if (m % i == 0 && n % i == 0)
                    {
                        gcd = i;
                        break; // Prematurely exit loop because gcd has been found.
                    }
                }
            }

            return gcd;  
        }


        // 'BruteForceGcd' Overload 2:
        // Uses exhaustive search to compute the greatest common divisor of 'm' and 'n'
        // long m, long n, returns long
        // 'BackgroundWorker' component needed because 'BruteForceGCD' is very slow when 'm' and 'n' are large.

        private static long BruteForceGcd(long m, long n, BackgroundWorker gcdBackgroundWorker)
        {
            // gcd(0, 0) is undefined -> indicated by returning -1 since gcd(m, n) >= 0
            long gcd = -1;

            if (m != 0 && n != 0)
            {
                gcd = 1; // If no common divisor > 1 is found, gcd must equal 1.

                // Algorithm only works if m >= 0 and n >= 0. (gcd(m, n) = gcd(|m|, |n|).)
                m = Math.Abs(m);
                n = Math.Abs(n);

                long smaller = Math.Min(m, n);

                for (long i = smaller; i >= 2 && !gcdBackgroundWorker.CancellationPending; i--)
                {
                    if (m % i == 0 && n % i == 0)
                    {
                        gcd = i;
                        break; // Prematurely exit loop because gcd has been found.
                    }
                }
            }

            return gcd; 
        }

        #endregion

        #region Event Handlers

        private void EuclideanGcdOverload1Button_Click(object sender, EventArgs e)
        {
            GcdLabel.Text = "";
            ExecutionTimeLabel.Text = "";

            bool conversion1Succeeded = int.TryParse(Num1TextBox.Text, out int a);
            bool conversion2Succeeded = int.TryParse(Num2TextBox.Text, out int b);

            if (conversion1Succeeded && conversion2Succeeded)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                int gcd = EuclideanGcd(a, b);

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;

                GcdLabel.Text = "gcd(" + a + ", " + b + ") = " + gcd;
                ExecutionTimeLabel.Text = "'EuclideanGcd' Overload 1: Execution Time = " + elapsedMs + " ms";
            }
            else
            {
                GcdLabel.Text = "Input(s) invalid.";
                ExecutionTimeLabel.Text = "At least one of the values entered is outside the range of an 'int' or not numeric.";
                //MessageBox.Show("At least one of the values entered is outside the range of an 'int' or not numeric.", "Oops!");
            }

        }

        private void EuclideanGcdOverload2Button_Click(object sender, EventArgs e)
        {
            GcdLabel.Text = "";
            ExecutionTimeLabel.Text = "";

            bool conversion1Succeeded = long.TryParse(Num1TextBox.Text, out long a);
            bool conversion2Succeeded = long.TryParse(Num2TextBox.Text, out long b);

            if (conversion1Succeeded && conversion2Succeeded)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                long gcd = EuclideanGcd(a, b);

                watch.Stop();
                //var elapsedMs = watch.ElapsedMilliseconds;

                GcdLabel.Text = "gcd(" + a + ", " + b + ") = " + gcd;
                ExecutionTimeLabel.Text = "'EuclideanGcd' Overload 2: Execution Time = " + watch.ElapsedMilliseconds + " ms";
            }
            else
            {
                GcdLabel.Text = "Input(s) invalid.";
                ExecutionTimeLabel.Text = "At least one of the values entered is outside the range of a 'long' or not numeric.";
            }


        }

        private void BruteForceGcdOverload1Button_Click(object sender, EventArgs e)
        {
            GcdLabel.Text = "This may take some time. Computing in the background...";
            ExecutionTimeLabel.Text = "";

            // Disable the gcd buttons. 
            // Clicking these buttons can cause problems while an asynchronous operation is running.
            EnableButtons(gcdButton, false);
            ComputingInBackgroundTimer.Enabled = true;

            // Run the brute-force gcd operation in the background. Note that 'RunWorkerAsync' has two overloads.
            // The first does not take any arguments. The second takes a single argument that can be used to
            // pass a message to the 'DoWork' event handler.
            BruteForceGCDBackgroundWorker.RunWorkerAsync(1); // '1' means overload 1
        }

        private void BruteForceGcdOverload2Button_Click(object sender, EventArgs e)
        {
            GcdLabel.Text = "This may take some time. Computing in the background...";
            ExecutionTimeLabel.Text = "";

            // Disable the gcd buttons. 
            // Clicking these buttons can cause problems while an asynchronous operation is running.
            EnableButtons(gcdButton, false);
            ComputingInBackgroundTimer.Enabled = true;

            // Run the brute-force gcd operation in the background. Note that 'RunWorkerAsync' has two overloads.
            // The first does not take any arguments. The second takes a single argument that can be used to
            // pass a message to the 'DoWork' event handler.
            BruteForceGCDBackgroundWorker.RunWorkerAsync(2); // '2' means overload 2
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            BruteForceGCDBackgroundWorker.CancelAsync();
        }

        private void BruteForceGCDBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int overloadCalled = (int)e.Argument;

            if (overloadCalled == 1)
            {
                bool conversion1Succeeded = int.TryParse(Num1TextBox.Text, out int a);
                bool conversion2Succeeded = int.TryParse(Num2TextBox.Text, out int b);

                if (conversion1Succeeded && conversion2Succeeded)
                {
                    // Do not access the form's BackgroundWorker reference directly.
                    // Instead, use the reference provided by the 'sender' parameter.
                    BackgroundWorker gcdBackgroundWorker = sender as BackgroundWorker;

                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    int gcd = BruteForceGcd(a, b, gcdBackgroundWorker); // Potentially time-consuming operation.

                    watch.Stop();

                    string timeTakenMessage = "'BruteForceGcd' Overload 1: Execution Time = " + watch.ElapsedMilliseconds + " ms";

                    if (gcd >= 0 && !gcdBackgroundWorker.CancellationPending)
                    {
                        e.Result = new string[] { "gcd(" + a + ", " + b + ") = " + gcd, timeTakenMessage };
                    }
                    else if (!gcdBackgroundWorker.CancellationPending)
                    {
                        e.Result = new string[] { "gcd(0, 0) is undefined", timeTakenMessage };
                    }
                    else // 'bw.CancellationPending' must be 'true'
                    {
                        // If the operation was cancelled by the user, set the 'DoWorkEventArgs.Cancel' property to true.
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Result = new string[] { "Input(s) invalid.", "At least one of the values entered is outside the range of an 'int' or not numeric." };
                }
            }
            else if (overloadCalled == 2)
            {
                bool conversion1Succeeded = long.TryParse(Num1TextBox.Text, out long a);
                bool conversion2Succeeded = long.TryParse(Num2TextBox.Text, out long b);

                if (conversion1Succeeded && conversion2Succeeded)
                {
                    // Do not access the form's BackgroundWorker reference directly.
                    // Instead, use the reference provided by the 'sender' parameter.
                    BackgroundWorker bw = sender as BackgroundWorker;

                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    long gcd = BruteForceGcd(a, b, bw); // Potentially time-consuming operation.

                    watch.Stop();

                    string timeTakenMessage = "'BruteForceGcd' Overload 2: Execution Time = " + watch.ElapsedMilliseconds + " ms";

                    if (gcd >= 0 && !bw.CancellationPending)
                    {
                        e.Result = new string[] { "gcd(" + a + ", " + b + ") = " + gcd, timeTakenMessage };
                    }
                    else if (!bw.CancellationPending)
                    {
                        e.Result = new string[] { "gcd(0, 0) is undefined", timeTakenMessage };
                    }
                    else // 'bw.CancellationPending' must be 'true'
                    {
                        // If the operation was cancelled by the user, set the 'DoWorkEventArgs.Cancel' property to true.
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Result = new string[] { "Input(s) invalid.", "At least one of the values entered is outside the range of a 'long' or not numeric." };
                }
            }

        }


        private void BruteForceGCDBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ComputingInBackgroundTimer.Enabled = false;
            GcdLabel.Visible = true;
            EnableButtons(gcdButton, true); // Safe to enable the buttons now.

            if (e.Cancelled)
            {
                // The user cancelled the operation.
                GcdLabel.Text = "Brute-force computation of GCD was aborted.";
                ExecutionTimeLabel.Text = "";
            }
            else
            {
                string[] result = (string[])e.Result;
                GcdLabel.Text = result[0];
                ExecutionTimeLabel.Text = result[1];
            }
        }

        // Used to produce the flashing effect when brute-force gcd takes a long time to return a result.
        private void ComputingInBackgroundTimer_Tick(object sender, EventArgs e)
        {
            if (GcdLabel.Visible)
            {
                GcdLabel.Visible = false;
            }
            else
            {
                GcdLabel.Visible = true;
            }
        }

        #endregion

        #region Miscellaneous Methods
        private void EnableButtons(Button[] button, bool enabled)
        {
            for (int i = 0; i < button.Length; i++)
            {
                button[i].Enabled = enabled;
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
