using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_cafeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rst_button_Click(object sender, EventArgs e)
        {
            //drinks
            cf_textbox1.Text = "0";
            cf_textBox2.Text = "0";
            cf_textBox3.Text = "0";
            cf_textBox4.Text = "0";
            cf_textBox5.Text = "0";
            cf_textBox6.Text = "0";
            cf_textBox7.Text = "0";
            cf_textBox8.Text = "0";
            //cakes
            ck_textBox1.Text = "0";
            ck_textBox2.Text = "0";
            ck_textBox3.Text = "0";
            ck_textBox4.Text = "0";
            ck_textBox5.Text = "0";
            ck_textBox6.Text = "0";
            ck_textBox7.Text = "0";
            ck_textBox8.Text = "0";
            //charges
            cakeCost_lbl.Text = "0";
            drinkCost_lbl.Text = "0";
            sc_lbl.Text = "80";
            tot_lbl.Text = "";
            st_lbl.Text = "";
            tax_lbl.Text = "";
            //uncheck all
            cf_1.Checked = false;
            cf_2.Checked = false;
            cf_3.Checked = false;
            cf_4.Checked = false;
            cf_5.Checked = false;
            cf_6.Checked = false;
            cf_7.Checked = false;
            cf_8.Checked = false;
            ck_1.Checked = false;
            ck_2.Checked = false;
            ck_3.Checked = false;
            ck_4.Checked = false;
            ck_5.Checked = false;
            ck_6.Checked = false;
            ck_7.Checked = false;
            ck_8.Checked = false;
            //disable all
            cf_textbox1.Enabled = false;
            cf_textBox2.Enabled = false;
            cf_textBox3.Enabled = false;
            cf_textBox4.Enabled = false;
            cf_textBox5.Enabled = false;
            cf_textBox6.Enabled = false;
            cf_textBox7.Enabled = false;
            cf_textBox8.Enabled = false;
            ck_textBox1.Enabled = false;
            ck_textBox2.Enabled = false;
            ck_textBox3.Enabled = false;
            ck_textBox4.Enabled = false;
            ck_textBox5.Enabled = false;
            ck_textBox6.Enabled = false;
            ck_textBox7.Enabled = false;
            ck_textBox8.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            date_lbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            //drinks
            cf_textbox1.Text = "0";
            cf_textBox2.Text = "0";
            cf_textBox3.Text = "0";
            cf_textBox4.Text = "0";
            cf_textBox5.Text = "0";
            cf_textBox6.Text = "0";
            cf_textBox7.Text = "0";
            cf_textBox8.Text = "0";
            //cakes
            ck_textBox1.Text = "0";
            ck_textBox2.Text = "0";
            ck_textBox3.Text = "0";
            ck_textBox4.Text = "0";
            ck_textBox5.Text = "0";
            ck_textBox6.Text = "0";
            ck_textBox7.Text = "0";
            ck_textBox8.Text = "0";
            //charges
            cakeCost_lbl.Text = "0";
            drinkCost_lbl.Text = "0";
            sc_lbl.Text = "80";
            tot_lbl.Text = "";
            st_lbl.Text = "";
            tax_lbl.Text = "";

            //disabling text in each text box
            cf_textbox1.Enabled = false;
            cf_textBox2.Enabled = false;
            cf_textBox3.Enabled = false;
            cf_textBox4.Enabled = false;
            cf_textBox5.Enabled = false;
            cf_textBox6.Enabled = false;
            cf_textBox7.Enabled = false;
            cf_textBox8.Enabled = false;
            ck_textBox1.Enabled = false;
            ck_textBox2.Enabled = false;
            ck_textBox3.Enabled = false;
            ck_textBox4.Enabled = false;
            ck_textBox5.Enabled = false;
            ck_textBox6.Enabled = false;
            ck_textBox7.Enabled = false;
            ck_textBox8.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cf_1_CheckedChanged(object sender, EventArgs e)
        {
            if (cf_1.Checked == true)
            {
                cf_textbox1.Enabled = true;
            //    cf_textbox1.Text = "";
                cf_textbox1.Focus();
            }
            else if (cf_1.Checked == false)
            {
                cf_textbox1.Enabled = false;
                cf_textbox1.Text = "0";
            }
        }

        private void cf_2_CheckedChanged(object sender, EventArgs e)
        {
            if (cf_2.Checked == true)
            {
                cf_textBox2.Enabled = true;
            //    cf_textBox2.Text = "";
                cf_textBox2.Focus();
            }
            else if (cf_2.Checked == false)
            {
                cf_textBox2.Enabled = false;
                cf_textBox2.Text = "0";
            }
        }

        private void cf_3_CheckedChanged(object sender, EventArgs e)
        {
            if (cf_3.Checked == true)
            {
                cf_textBox3.Enabled = true;
            //    cf_textBox3.Text = "";
                cf_textBox3.Focus();
            }
            else if (cf_3.Checked == false)
            {
                cf_textBox3.Enabled = false;
                cf_textBox3.Text = "0";
            }
        }

        private void cf_4_CheckedChanged(object sender, EventArgs e)
        {
            if (cf_4.Checked == true)
            {
                cf_textBox4.Enabled = true;
            //    cf_textBox4.Text = "";
                cf_textBox4.Focus();
            }
            else if (cf_4.Checked == false)
            {
                cf_textBox4.Enabled = false;
                cf_textBox4.Text = "0";
            }
        }

        private void cf_5_CheckedChanged(object sender, EventArgs e)
        {
            if (cf_5.Checked == true)
            {
                cf_textBox5.Enabled = true;
            //    cf_textBox5.Text = "";
                cf_textBox5.Focus();
            }
            else if (cf_5.Checked == false)
            {
                cf_textBox5.Enabled = false;
                cf_textBox5.Text = "0";
            }
        }

        private void cf_6_CheckedChanged(object sender, EventArgs e)
        {
            if (cf_6.Checked == true)
            {
                cf_textBox6.Enabled = true;
            //    cf_textBox6.Text = "";
                cf_textBox6.Focus();
            }
            else if (cf_6.Checked == false)
            {
                cf_textBox6.Enabled = false;
                cf_textBox6.Text = "0";
            }
        }

        private void cf_7_CheckedChanged(object sender, EventArgs e)
        {
            if (cf_7.Checked == true)
            {
                cf_textBox7.Enabled = true;
            //    cf_textBox7.Text = "";
                cf_textBox7.Focus();
            }
            else if (cf_7.Checked == false)
            {
                cf_textBox7.Enabled = false;
                cf_textBox7.Text = "0";
            }
        }

        private void cf_8_CheckedChanged(object sender, EventArgs e)
        {
            if (cf_8.Checked == true)
            {
                cf_textBox8.Enabled = true;
            //    cf_textBox8.Text = "";
                cf_textBox8.Focus();
            }
            else if (cf_8.Checked == false)
            {
                cf_textBox8.Enabled = false;
                cf_textBox8.Text = "0";
            }
        }

        private void ck_1_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_1.Checked == true)
            {
                ck_textBox1.Enabled = true;
            //    ck_textBox1.Text = "";
                ck_textBox1.Focus();
            }
            else if (ck_1.Checked == false)
            {
                ck_textBox1.Enabled = false;
                ck_textBox1.Text = "0";
            }
        }

        private void ck_2_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_2.Checked == true)
            {
                ck_textBox2.Enabled = true;
            //    ck_textBox2.Text = "";
                ck_textBox2.Focus();
            }
            else if (ck_2.Checked == false)
            {
                ck_textBox2.Enabled = false;
                ck_textBox2.Text = "0";
            }
        }

        private void ck_3_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_3.Checked == true)
            {
                ck_textBox3.Enabled = true;
            //    ck_textBox3.Text = "";
                ck_textBox3.Focus();
            }
            else if (ck_3.Checked == false)
            {
                ck_textBox3.Enabled = false;
                ck_textBox3.Text = "0";
            }
        }

        private void ck_4_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_4.Checked == true)
            {
                ck_textBox4.Enabled = true;
            //    ck_textBox4.Text = "";
                ck_textBox4.Focus();
            }
            else if (ck_4.Checked == false)
            {
                ck_textBox4.Enabled = false;
                ck_textBox4.Text = "0";
            }
        }

        private void ck_5_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_5.Checked == true)
            {
                ck_textBox5.Enabled = true;
            //    ck_textBox5.Text = "";
                ck_textBox5.Focus();
            }
            else if (ck_5.Checked == false)
            {
                ck_textBox5.Enabled = false;
                ck_textBox5.Text = "0";
            }
        }

        private void ck_6_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_6.Checked == true)
            {
                ck_textBox6.Enabled = true;
            //    ck_textBox6.Text = "";
                ck_textBox6.Focus();
            }
            else if (ck_6.Checked == false)
            {
                ck_textBox6.Enabled = false;
                ck_textBox6.Text = "0";
            }
        }

        private void ck_7_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_7.Checked == true)
            {
                ck_textBox7.Enabled = true;
            //    ck_textBox7.Text = "";
                ck_textBox7.Focus();
            }
            else if (ck_7.Checked == false)
            {
                ck_textBox7.Enabled = false;
                ck_textBox7.Text = "0";
            }
        }

        private void ck_8_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_8.Checked == true)
            {
                ck_textBox8.Enabled = true;
               // ck_textBox8.Text = "";
                ck_textBox8.Focus();
            }
            else if (ck_8.Checked == false)
            {
                ck_textBox8.Enabled = false;
                ck_textBox8.Text = "0";
            }
        }

        private void cf_textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cf_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rpt_richTextBox.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rpt_richTextBox.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rpt_richTextBox.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rpt_richTextBox.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rpt_richTextBox.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //this will open text file
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rpt_richTextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                {
                    sw.WriteLine(rpt_richTextBox.Text);
                }
            }
        }
        Double cf1 = 300, cf2=320, cf3=300, cf4=400, cf5=250, cf6=380, cf7=410, cf8=480;
        Double ck1=880, ck2=920, ck3=790, ck4=810, ck5=1100, ck6=900, ck7=800, ck8=750;
        Double tax = .95;

        private void rpt_button_Click(object sender, EventArgs e)
        {
            rpt_richTextBox.Clear();
            rpt_richTextBox.AppendText(Environment.NewLine);
            rpt_richTextBox.AppendText("-----------------------------------------------------------------------------------" + Environment.NewLine);
            rpt_richTextBox.AppendText("\t\t\t" + "Cafe Receipt " + Environment.NewLine);
            rpt_richTextBox.AppendText("-----------------------------------------------------------------------------------" + Environment.NewLine);
            rpt_richTextBox.AppendText("\t\t\t  Quantity\tPrice" + Environment.NewLine);
            rpt_richTextBox.AppendText("**** Drinks ****" + Environment.NewLine);
            rpt_richTextBox.AppendText("Latte\t\t\t\t" + cf_textbox1.Text +"\t"+cf1+ Environment.NewLine);
            rpt_richTextBox.AppendText("Espresso\t\t\t" + cf_textBox2.Text + "\t" + cf2 + Environment.NewLine);
            rpt_richTextBox.AppendText("Iced Latte\t\t\t" + cf_textBox3.Text + "\t" + cf3 + Environment.NewLine);
            rpt_richTextBox.AppendText("Vale Coffee\t\t\t" + cf_textBox4.Text + "\t" + cf4 + Environment.NewLine);
            rpt_richTextBox.AppendText("Cuppuccino\t\t\t" + cf_textBox5.Text + "\t" + cf5 + Environment.NewLine);
            rpt_richTextBox.AppendText("African Coffee\t\t\t" + cf_textBox6.Text + "\t" + cf6 + Environment.NewLine);
            rpt_richTextBox.AppendText("American Coffee\t\t\t" + cf_textBox7.Text + "\t" + cf7 + Environment.NewLine);
            rpt_richTextBox.AppendText("Iced Cuppucino\t\t\t" + cf_textBox8.Text + "\t" + cf8 + Environment.NewLine);
            rpt_richTextBox.AppendText("**** Cakes ****" + Environment.NewLine);
            rpt_richTextBox.AppendText("Coffee Cake\t\t\t" + ck_textBox1.Text + "\t" + ck1 + Environment.NewLine);
            rpt_richTextBox.AppendText("Red Velvet Cake\t\t\t" + ck_textBox2.Text + "\t" + ck2 + Environment.NewLine);
            rpt_richTextBox.AppendText("Black Forest Cake\t\t" + ck_textBox3.Text + "\t" + ck3 + Environment.NewLine);
            rpt_richTextBox.AppendText("Chocolate Fudge Cake\t\t" + ck_textBox4.Text + "\t" + ck4 + Environment.NewLine);
            rpt_richTextBox.AppendText("Boston Cream Cake\t\t" + ck_textBox5.Text + "\t" + ck5 + Environment.NewLine);
            rpt_richTextBox.AppendText("KillBurn Chocolate Cake\t\t" + ck_textBox7.Text + "\t" + ck7 + Environment.NewLine);
            rpt_richTextBox.AppendText("Lagos Chocolate Cake\t\t" + ck_textBox6.Text + "\t" + ck6 + Environment.NewLine);
            rpt_richTextBox.AppendText("PineApple Cream Cake\t\t" + ck_textBox8.Text + "\t" + ck8 + Environment.NewLine);
            rpt_richTextBox.AppendText("-----------------------------------------------------------------------------------" + Environment.NewLine);
            rpt_richTextBox.AppendText("Service Charges\t\t\t"+sc_lbl.Text+Environment.NewLine);
            rpt_richTextBox.AppendText("-----------------------------------------------------------------------------------" + Environment.NewLine);
            rpt_richTextBox.AppendText("Tax \t\t\t\tRs " + tax_lbl.Text + Environment.NewLine);
            rpt_richTextBox.AppendText("Sub Total\t\t\tRs " + st_lbl.Text + Environment.NewLine);
            rpt_richTextBox.AppendText("Total\t\t\t\tRs " + tot_lbl.Text + "only."+ Environment.NewLine);
            rpt_richTextBox.AppendText("-----------------------------------------------------------------------------------" + Environment.NewLine);
            rpt_richTextBox.AppendText(time_lbl.Text + "\t\t\t  " + date_lbl.Text);
        }
        
        private void tot_button_Click(object sender, EventArgs e)
        {
            Double tck1 = Convert.ToDouble(ck_textBox1.Text) * ck1;
            Double tck2 = Convert.ToDouble(ck_textBox2.Text) * ck2;
            Double tck3 = Convert.ToDouble(ck_textBox3.Text) * ck3;
            Double tck4 = Convert.ToDouble(ck_textBox4.Text) * ck4;
            Double tck5 = Convert.ToDouble(ck_textBox5.Text) * ck5;
            Double tck6 = Convert.ToDouble(ck_textBox6.Text) * ck6;
            Double tck7 = Convert.ToDouble(ck_textBox7.Text) * ck7;
            Double tck8 = Convert.ToDouble(ck_textBox8.Text) * ck8;

            Double tcf1 = Convert.ToDouble(cf_textbox1.Text) * cf1;
            Double tcf2 = Convert.ToDouble(cf_textBox2.Text) * cf2;
            Double tcf3 = Convert.ToDouble(cf_textBox3.Text) * cf3;
            Double tcf4 = Convert.ToDouble(cf_textBox4.Text) * cf4;
            Double tcf5 = Convert.ToDouble(cf_textBox5.Text) * cf5;
            Double tcf6 = Convert.ToDouble(cf_textBox6.Text) * cf6;
            Double tcf7 = Convert.ToDouble(cf_textBox7.Text) * cf7;
            Double tcf8 = Convert.ToDouble(cf_textBox8.Text) * cf8;

            cafe eatCafe = new cafe(tck1, tck2, tck3, tck4, tck5, tck6, tck7
                , tck8, tcf1, tcf2, tcf3, tcf4, tcf5, tcf6, tcf7, tcf8);

            //total cost of drinks
            Double cost_of_drinks = tcf1 + tcf2 + tcf3 + tcf4 + tcf5 + tcf6 + tcf7 + tcf8;
            drinkCost_lbl.Text = Convert.ToString(cost_of_drinks);

            //total cost of cakes
            Double cost_of_cake = tck1 + tck2 + tck3 + tck4 + tck5 + tck6 + tck7 + tck8;
            cakeCost_lbl.Text = Convert.ToString(cost_of_cake);

            //service charges
            Double serviceCharge = Convert.ToDouble(sc_lbl.Text);

            st_lbl.Text = Convert.ToString(serviceCharge + cost_of_cake + cost_of_drinks);
            Double st = Convert.ToDouble(st_lbl.Text);
            Double tot_tax = (((serviceCharge + cost_of_cake + cost_of_drinks) * tax) / 100);
            tax_lbl.Text = Convert.ToString(tot_tax);
            tot_lbl.Text = Convert.ToString(st + tot_tax);


        }
    }
}


