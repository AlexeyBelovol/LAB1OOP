namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void valueA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void valueB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void valueC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void valueD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            e.Handled = true;
        }

        private void check_result_Click(object sender, EventArgs e)
        {
            if (valueA.TextLength != 0 && valueB.TextLength != 0 && valueC.TextLength != 0 && valueD.TextLength != 0)
            {
                double a = Convert.ToDouble(valueA.Text);
                double b = Convert.ToDouble(valueB.Text);
                double c = Convert.ToDouble(valueC.Text);
                double d = Convert.ToDouble(valueD.Text);
                double result = (((a / b) * (b / c)) - (((a * b) - c) / (c * d)));
                resultlbl.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void v_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void v1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void t1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void t2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void result2_Click(object sender, EventArgs e)
        {
            if (v.TextLength != 0 && v1.TextLength != 0 && t1.TextLength != 0 && t2.TextLength != 0)
            {
                double v_value = Convert.ToDouble(v.Text);
                double v1_value = Convert.ToDouble(v1.Text);
                double t1_value = Convert.ToDouble(t1.Text);
                double t2_value = Convert.ToDouble(t2.Text);
                double downstream = v_value + v1_value;
                double upstream = v_value - v1_value;
                double s = (downstream * t1_value) + (upstream * t2_value);
                result_s.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void three_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void check_number_Click(object sender, EventArgs e)
        {
            if (three_number.TextLength == 3)
            {
                if (int.TryParse(three_number.Text, out int number) && number >= 100 && number <= 999)
                {
                    int digit1 = number / 100;
                    int digit2 = (number / 10) % 10;
                    int digit3 = number % 10;
                    int sum = digit1 + digit2 + digit3;
                    bool isSumEven = sum % 2 == 1;
                    CheckResult.Text = isSumEven.ToString();
                }
                else
                {
                    MessageBox.Show("Input 3-digit number!");
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void X1Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void Y1Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void X2Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void Y2Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void X3Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void Y3Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void X4Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void Y4Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (X1Value.TextLength != 0 && Y1Value.TextLength != 0 && X2Value.TextLength != 0 && Y2Value.TextLength != 0 && X3Value.TextLength != 0 && Y3Value.TextLength != 0 && X4Value.TextLength != 0 && Y4Value.TextLength != 0)
            {
                double x1 = Convert.ToDouble(X1Value.Text);
                double y1 = Convert.ToDouble(Y1Value.Text);
                double x2 = Convert.ToDouble(X2Value.Text);
                double y2 = Convert.ToDouble(Y2Value.Text);
                double x3 = Convert.ToDouble(X3Value.Text);
                double y3 = Convert.ToDouble(Y3Value.Text);
                double x4 = Convert.ToDouble(X4Value.Text);
                double y4 = Convert.ToDouble(Y4Value.Text);
                bool isConvex = CheckConvexQuadrilateral((float)x1, (float)y1, (float)x2, (float)y2, (float)x3, (float)y3, (float)x4, (float)y4);
                bool CheckConvexQuadrilateral(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
                {
                    double angle1 = Math.Atan2(y2 - y1, x2 - x1) - Math.Atan2(y4 - y1, x4 - x1);
                    double angle2 = Math.Atan2(y3 - y2, x3 - x2) - Math.Atan2(y1 - y2, x1 - x2);
                    double angle3 = Math.Atan2(y4 - y3, x4 - x3) - Math.Atan2(y2 - y3, x2 - x3);
                    double angle4 = Math.Atan2(y1 - y4, x1 - x4) - Math.Atan2(y3 - y4, x3 - x4);

                    if (angle1 >= Math.PI) angle1 -= 2 * Math.PI;
                    if (angle2 >= Math.PI) angle2 -= 2 * Math.PI;
                    if (angle3 >= Math.PI) angle3 -= 2 * Math.PI;
                    if (angle4 >= Math.PI) angle4 -= 2 * Math.PI;

                    if (angle1 < 0 || angle2 < 0 || angle3 < 0 || angle4 < 0)
                        return false;
                    else
                        return true;
                }
                if (isConvex)
                {
                    CheckCordRes.Text = "upright is convex";
                }
                else
                {
                    CheckCordRes.Text = "upright is not convex";
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void FiveA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void FiveB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void FiveC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void FiveD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0')
            {
                return;
            }
            e.Handled = true;
        }

        private void result5_Click(object sender, EventArgs e)
        {
            double AFive = Convert.ToDouble(FiveA.Text);
            double BFive = Convert.ToDouble(FiveB.Text);
            double CFive = Convert.ToDouble(FiveC.Text);
            double DFive = Convert.ToDouble(FiveD.Text);
            List<double> roots = new List<double>();
            for (double pd = -Math.Abs(DFive); pd <= Math.Abs(DFive); pd++)
            {
                if (pd != 0 && DFive % pd == 0)
                {
                    double x = pd;
                    double equationResult = AFive * Math.Pow(x, 3) + BFive * Math.Pow(x, 2) + CFive * x + DFive;
                    if (Math.Abs(equationResult) < 1e-10)
                    {
                        roots.Add(pd);
                    }
                }
            }
            if (roots.Count > 0)
            {
                CalculateResult.Text = string.Join(", ", roots);
            }
            else
            {
                CalculateResult.Text = "Коренів не знайдено";
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void CheckSequense_Click(object sender, EventArgs e)
        {
            string inputA = SequenseA.Text;
            string inputB = SequenseB.Text;
            int[] sequenceA = inputA.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] sequenceB = inputB.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool allElementsInSequenceA = sequenceB.All(elementB => sequenceA.Contains(elementB));
            if (allElementsInSequenceA)
            {
                allElementsInSequence.Text = ("Всі елементи другої послідовності входять в першу.");
            }
            else
            {
                allElementsInSequence.Text = ("Послідовності різні");
            }
        }

        private void CheckB_Click(object sender, EventArgs e)
        {
            string text = TextWithB.Text;
            string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words)
            {
                if (word.StartsWith("b", StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            CountBResult.Text = count.ToString();
        }
    }
}

