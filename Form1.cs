using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalTestVersion1
{
    public partial class Form1 : Form
    {
        int sign_Indicator = 0;
        double variable1;
        double variable2;
        int additionPart = 0;
        int subbtractionPart = 0;
        int multiplicationPart = 0;
        int divisionPart = 0;
        int modBit = 0;
        double currency = 30.3;
        double percent = 0.0;
        Boolean fl = false;
        String s, x;

        decimal MemoryStore = 0;
        decimal EndResult = 0;
    

        public Form1()
        {
            InitializeComponent();
        }
        //1
        private void One_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(1);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(1);
                sign_Indicator = 0;
            }
            fl = true;
            richTextBox1.Text += One.Text;
        }
        //2
        private void Two_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(2);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(2);
                sign_Indicator = 0;
            }
            fl = true;
            richTextBox1.Text += Two.Text;
        }
        //3
        private void Three_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(3);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(3);
                sign_Indicator = 0;
            }
            fl = true;
            richTextBox1.Text += Three.Text;
        }
        //4
        private void Four_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(4);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(4);
                sign_Indicator = 0;
            }
            fl = true;
            richTextBox1.Text += Four.Text;
        }
        //5
        private void Five_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(5);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(5);
                sign_Indicator = 0;
            }
            fl = true;
            richTextBox1.Text += Five.Text;
        }
        //6
        private void Six_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(6);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(6);
                sign_Indicator = 0;
            }
            fl = true;
            richTextBox1.Text += Six.Text;
        }
        //7
        private void Seven_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(7);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(7);
                sign_Indicator = 0;
            }
            fl = true;
            richTextBox1.Text += Seven.Text;
        }
        //8
        private void Eight_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(8);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(8);
                sign_Indicator = 0;
            }
            fl = true;
            richTextBox1.Text += Eight.Text;
        }
        //9
        private void Nine_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(9);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(9);
                sign_Indicator = 0;
            }
            fl = true;
            richTextBox1.Text += Nine.Text;
        }
        //0
        private void Zero_Click(object sender, EventArgs e)
        {
            if (sign_Indicator == 0)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(0);
            }
            else if (sign_Indicator == 1)
            {
                textBox1.Text = Convert.ToString(0);
                sign_Indicator = 0;
            }
            fl = true;
            richTextBox1.Text += Zero.Text;
        }


        private void reset_SignBits()
        {
            additionPart = 0;
            subbtractionPart = 0;
            multiplicationPart = 0;
            divisionPart = 0;
            modBit = 0;
            fl = false;
        }
        //Add
        private void Addition_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                additionPart = 1;
                sign_Indicator = 1;
            }
            richTextBox1.Text += Addition.Text;
        }
        //Substract
        private void Substraction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                //variable2 = Convert.ToDouble(txtInput.Text);
                calculate();
                reset_SignBits();
                subbtractionPart = 1;
                sign_Indicator = 1;
            }
            richTextBox1.Text += Substraction.Text;
        }
        //Divide
        private void Division_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                divisionPart = 1;
                sign_Indicator = 1;
            }
            richTextBox1.Text += Division.Text;
        }
        //Multiply
        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                multiplicationPart = 1;
                sign_Indicator = 1;
            }
            richTextBox1.Text += Multiplication.Text;
        }
        //Backspace
        private void BackSpace_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            int l = s.Length;
            for (int i = 0; i < l - 1; i++)
            {
                x += s[i];
            }
            textBox1.Text = x;
            x = "";
        }
        //Square
        private void Square_Click(object sender, EventArgs e)
        {
            double s, l;
            l = Convert.ToDouble(textBox1.Text);
            s = Math.Sqrt(l);
            textBox1.Text = Convert.ToString(s);
            richTextBox1.Text += Square.Text;
        }
        //%
        private void Percent_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
             {
                percent = Convert.ToDouble(textBox1.Text);
                textBox1.Text = ((variable1 / 100) * percent).ToString();
             }
             else
                textBox1.Text = "0";
            /*double p;
            p = (Convert.ToDouble(textBox1.Text) / 100);
            textBox1.Text = Convert.ToString(p);
            richTextBox1.Text += Percent.Text;*/
        }
        //Fraction
        private void Fraction_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / Convert.ToDouble(textBox1.Text)).ToString();
            richTextBox1.Text += Fraction.Text;
        }
        //Permutation
        private void Permutation_Click(object sender, EventArgs e)
        {
            try
            {
                long fact = 1;
                for (int i = 1; i <= Convert.ToInt32(textBox1.Text); i++)
                {
                    fact = fact * i;
                }
                textBox1.Text = Convert.ToString(fact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += Permutation.Text;
        }
        //log
        private void log_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Log(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += log.Text;
        }
        //log10
        private void log10_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Log10(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += log10.Text;
        }
        //Exponential
        private void Exponential_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Exp(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += Exponential.Text;
        }
        //sin
        private void sin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Sin(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += sin.Text;
        }
        //cos
        private void cos_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Cos(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += cos.Text;
        }
        //tan
        private void tan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Tan(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += tan.Text;
        }
        //Round
        private void Round_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Round(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += Round.Text;
        }
        //Floor
        private void Floor_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Floor(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += Floor.Text;
        }
        //Trunc
        private void Trunc_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Truncate(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += Trunc.Text;
        }
        //Ceil
        private void Ceil_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Ceiling(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += Ceil.Text;
        }
        //sinInverse
        private void sinInverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Asin(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += sinInverse.Text;
        }
        //sinH
        private void sinH_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Sinh(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += sinH.Text;
        }
        //cosH
        private void cosH_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Cosh(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += cosH.Text;
        }
        //tanH
        private void tanH_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Tanh(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += tanH.Text;
        }
        //cosInverse
        private void cosInverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Acos(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += cosInverse.Text;
        }
        //tanInverse
        private void tanInverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length != 0)
                {
                    double l;
                    l = Math.Atan(Convert.ToDouble(textBox1.Text));
                    textBox1.Text = Convert.ToString(l);
                }
                sign_Indicator = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox1.Text += tanInverse.Text;
        }
        //Mod
        private void Mod_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
                modBit = 1;
                sign_Indicator = 1;
            }
            richTextBox1.Text += Mod.Text;
        }
        //PI
        private void PI_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
            sign_Indicator = 1;
            richTextBox1.Text += PI.Text;
        }
        //Decimal
        private void Decimal_Click(object sender, EventArgs e)
        {
            int i = 0;
            char chr = '\0';
            double decimal_Indicator = 0;
            int l = textBox1.Text.Length - 1;
            if (sign_Indicator != 1)
            {
                for (i = 0; i <= l; i++)
                {
                    chr = textBox1.Text[i];
                    if (chr == '.')
                    {
                        decimal_Indicator = 1;
                    }
                }

                if (decimal_Indicator != 1 && textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text + Convert.ToString(".");
                }
                else
                {
                    textBox1.Text = "0" + Convert.ToString(".");
                }
            }
            richTextBox1.Text += Decimal.Text;
        }
        //Clear
        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            sign_Indicator = 0;
            variable1 = 0;
            variable2 = 0;
            reset_SignBits();

        }
        //Equal
        private void Equal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                calculate();
                reset_SignBits();
            }
            sign_Indicator = 1;
            richTextBox1.Text += Equal.Text + textBox1.Text 
                + "\n";
        }
        //Form1 load
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Square
        private void sq_Click(object sender, EventArgs e)
        {
            double s, l;
            l = Convert.ToDouble(textBox1.Text);
            s = Math.Pow(l, 2);
            textBox1.Text = Convert.ToString(s);
            richTextBox1.Text += sq.Text;
        }
        //Power
        private void Power_Click(object sender, EventArgs e)
        {
            double s, l;
            l = Convert.ToDouble(textBox1.Text);
            s = Math.Pow(l, l);
            textBox1.Text = Convert.ToString(s);
            richTextBox1.Text += Power.Text;
        }
        //x^3
        private void xP3_Click(object sender, EventArgs e)
        {
            double s, l;
            l = Convert.ToDouble(textBox1.Text);
            s = Math.Pow(l, 3);
            textBox1.Text = Convert.ToString(s);
            richTextBox1.Text += xP3.Text;
        }
        //10^x
        private void Px_Click(object sender, EventArgs e)
        {
            double s, l;
            l = Convert.ToDouble(textBox1.Text);
            s = Math.Pow(10, l);
            textBox1.Text = Convert.ToString(s);
            richTextBox1.Text += Px.Text;
        }
        //CE
        private void CE_Click(object sender, EventArgs e)
        {
            if(variable1==0 && textBox1.TextLength>0)
            {
                variable1 = 0;
                textBox1.Clear();
            }else if(variable1>0 && textBox1.TextLength>0)
            {
                textBox1.Clear();
            }
        }
        //Memory Clear
        private void MC_Click(object sender, EventArgs e)
        {
            this.MemoryStore = 0;
            return;
        }
        // Memory add
        private void MPlus_Click(object sender, EventArgs e)
        { 
            this.MemoryStore += Convert.ToDecimal(this.EndResult);
            return;
        }
        // Memory minus
        private void MMinus_Click(object sender, EventArgs e)
        {
            this.MemoryStore -= Convert.ToDecimal(this.EndResult);
            return;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1 && textBox1.TextLength > 0)
             {
                double current = Convert.ToDouble(textBox1.Text);
                String type = listBox1.SelectedItem.ToString();
                   if (type == "THB  -->  USD")
                    {
                    double newCurrent = (current / currency);
                    textBox1.Text = newCurrent.ToString();
                    richTextBox2.Text += (current + "$ = " + newCurrent + "B\n");
                }
                   else if (type == "USD  -->  THB")
                    {
                    double newCurrent = (current * currency);
                    textBox1.Text = newCurrent.ToString();
                    richTextBox2.Text += (current + "B = " + newCurrent + "$\n");
                }
             }
        }



        //Calculation method
        private void calculate()
        {
            if (textBox1.Text != ".")
            {
                variable2 = Convert.ToDouble(textBox1.Text);
                if (fl == false)
                {
                    variable1 = variable2;
                }
                else if (additionPart == 1)
                {
                    variable1 = variable1 + variable2;
                }
                else if (subbtractionPart == 1)
                {
                    variable1 = variable1 - variable2;
                }
                else if (multiplicationPart == 1)
                {
                    variable1 = variable1 * variable2;
                }
                else if (divisionPart == 1)
                {
                    variable1 = variable1 / variable2;
                }
                else if (modBit == 1)
                {

                    variable2 = Convert.ToInt32(textBox1.Text);
                    variable1 = Convert.ToInt32(variable1 % variable2);
                }
                else
                {
                    variable1 = variable2;
                }
                textBox1.Text = Convert.ToString(variable1);

                
            }
           
        }
    }
}
