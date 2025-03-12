using System;
using System.Windows.Forms;

namespace KPL_TiurmaGraceA_2311104042_S1SE_07_02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel operatorPanel;
        private System.Windows.Forms.Label labelOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.operatorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.Text = "Kalkulator Sederhana";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.labelOutput.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelOutput.Location = new System.Drawing.Point(12, 20);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(360, 50);
            this.labelOutput.Text = "0";
            this.labelOutput.BackColor = System.Drawing.Color.White;
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 90);
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 320);
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            AddButtons();

            this.operatorPanel.ColumnCount = 1;
            this.operatorPanel.RowCount = 2;
            this.operatorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.operatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operatorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operatorPanel.Location = new System.Drawing.Point(270, 90);
            this.operatorPanel.Size = new System.Drawing.Size(80, 160);
            this.operatorPanel.BackColor = System.Drawing.Color.White;
            AddOperatorButtons();

            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.operatorPanel);
            this.ResumeLayout(false);
        }

        private void AddButtons()
        {
            string[,] buttonTexts = new string[4, 3]
            {
        { "1", "2", "3" },
        { "4", "5", "6" },
        { "7", "8", "9" },
        { "", "0", "" }
            };

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (buttonTexts[row, col] != "")
                    {
                        Button btn = new Button();
                        btn.Dock = System.Windows.Forms.DockStyle.Fill;
                        btn.Font = new System.Drawing.Font("Segoe UI", 18F);
                        btn.Text = buttonTexts[row, col];
                        btn.Click += new System.EventHandler(this.Button_Click);
                        btn.BackColor = System.Drawing.Color.LightSkyBlue;

                        if (buttonTexts[row, col] == "0")
                        {
                            tableLayoutPanel1.SetColumnSpan(btn, 1);
                            tableLayoutPanel1.Controls.Add(btn, 1, row);
                        }
                        else
                        {
                            tableLayoutPanel1.Controls.Add(btn, col, row);
                        }
                    }
                }
            }
        }


        private void AddOperatorButtons()
        {
            string[] operators = { "+", "=" };

            for (int i = 0; i < 2; i++)
            {
                Button btn = new Button();
                btn.Dock = System.Windows.Forms.DockStyle.Fill;
                btn.Font = new System.Drawing.Font("Segoe UI", 18F);
                btn.Text = operators[i];
                btn.Click += new System.EventHandler(this.Button_Click);
                btn.BackColor = System.Drawing.Color.Orange;
                operatorPanel.Controls.Add(btn, 0, i);
            }
        }

        #endregion
    }
}
