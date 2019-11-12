namespace TravelCost
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selChevy = new System.Windows.Forms.RadioButton();
            this.selBuick = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selFreeway = new System.Windows.Forms.RadioButton();
            this.selCity = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selChevy);
            this.groupBox1.Controls.Add(this.selBuick);
            this.groupBox1.Location = new System.Drawing.Point(53, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle";
            // 
            // selChevy
            // 
            this.selChevy.AutoSize = true;
            this.selChevy.Location = new System.Drawing.Point(15, 60);
            this.selChevy.Name = "selChevy";
            this.selChevy.Size = new System.Drawing.Size(92, 17);
            this.selChevy.TabIndex = 1;
            this.selChevy.TabStop = true;
            this.selChevy.Text = "Chevy Lumina";
            this.selChevy.UseVisualStyleBackColor = true;
            // 
            // selBuick
            // 
            this.selBuick.AutoSize = true;
            this.selBuick.Location = new System.Drawing.Point(15, 27);
            this.selBuick.Name = "selBuick";
            this.selBuick.Size = new System.Drawing.Size(88, 17);
            this.selBuick.TabIndex = 0;
            this.selBuick.TabStop = true;
            this.selBuick.Text = "Buick Electra";
            this.selBuick.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selFreeway);
            this.groupBox2.Controls.Add(this.selCity);
            this.groupBox2.Location = new System.Drawing.Point(53, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Route";
            // 
            // selFreeway
            // 
            this.selFreeway.AutoSize = true;
            this.selFreeway.Location = new System.Drawing.Point(15, 62);
            this.selFreeway.Name = "selFreeway";
            this.selFreeway.Size = new System.Drawing.Size(65, 17);
            this.selFreeway.TabIndex = 1;
            this.selFreeway.TabStop = true;
            this.selFreeway.Text = "Freeway";
            this.selFreeway.UseVisualStyleBackColor = true;
            // 
            // selCity
            // 
            this.selCity.AutoSize = true;
            this.selCity.Location = new System.Drawing.Point(15, 30);
            this.selCity.Name = "selCity";
            this.selCity.Size = new System.Drawing.Size(42, 17);
            this.selCity.TabIndex = 0;
            this.selCity.TabStop = true;
            this.selCity.Text = "City";
            this.selCity.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(53, 320);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(565, 26);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(634, 320);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 26);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mileage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Miles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gas Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Cost:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(443, 192);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Travel Expense Calculator";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(507, 82);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(35, 13);
            this.lblMileage.TabIndex = 10;
            this.lblMileage.Text = "label6";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(507, 113);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(35, 13);
            this.lblMiles.TabIndex = 11;
            this.lblMiles.Text = "label7";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(443, 227);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 364);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton selChevy;
        private System.Windows.Forms.RadioButton selBuick;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton selFreeway;
        private System.Windows.Forms.RadioButton selCity;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblTotal;
    }
}

