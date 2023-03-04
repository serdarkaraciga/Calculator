namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screen1 = new System.Windows.Forms.Label();
            this.number1Button = new System.Windows.Forms.Button();
            this.number2Button = new System.Windows.Forms.Button();
            this.number3Button = new System.Windows.Forms.Button();
            this.number6Button = new System.Windows.Forms.Button();
            this.number5Button = new System.Windows.Forms.Button();
            this.number4Button = new System.Windows.Forms.Button();
            this.number9Button = new System.Windows.Forms.Button();
            this.number8Button = new System.Windows.Forms.Button();
            this.number7Button = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.number0Button = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.impact = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screen1
            // 
            this.screen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.screen1.Location = new System.Drawing.Point(12, 9);
            this.screen1.Name = "screen1";
            this.screen1.Size = new System.Drawing.Size(254, 52);
            this.screen1.TabIndex = 0;
            this.screen1.Text = "0";
            this.screen1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.screen1.Click += new System.EventHandler(this.label1_Click);
            // 
            // number1Button
            // 
            this.number1Button.BackColor = System.Drawing.Color.Tomato;
            this.number1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number1Button.Location = new System.Drawing.Point(12, 70);
            this.number1Button.Name = "number1Button";
            this.number1Button.Size = new System.Drawing.Size(60, 60);
            this.number1Button.TabIndex = 1;
            this.number1Button.Text = "1";
            this.number1Button.UseVisualStyleBackColor = false;
            this.number1Button.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2Button
            // 
            this.number2Button.BackColor = System.Drawing.Color.Tomato;
            this.number2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number2Button.Location = new System.Drawing.Point(77, 70);
            this.number2Button.Name = "number2Button";
            this.number2Button.Size = new System.Drawing.Size(60, 60);
            this.number2Button.TabIndex = 2;
            this.number2Button.Text = "2";
            this.number2Button.UseVisualStyleBackColor = false;
            this.number2Button.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3Button
            // 
            this.number3Button.BackColor = System.Drawing.Color.Tomato;
            this.number3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number3Button.Location = new System.Drawing.Point(142, 70);
            this.number3Button.Name = "number3Button";
            this.number3Button.Size = new System.Drawing.Size(60, 60);
            this.number3Button.TabIndex = 3;
            this.number3Button.Text = "3";
            this.number3Button.UseVisualStyleBackColor = false;
            this.number3Button.Click += new System.EventHandler(this.number3_Click);
            // 
            // number6Button
            // 
            this.number6Button.BackColor = System.Drawing.Color.Tomato;
            this.number6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number6Button.Location = new System.Drawing.Point(142, 132);
            this.number6Button.Name = "number6Button";
            this.number6Button.Size = new System.Drawing.Size(60, 60);
            this.number6Button.TabIndex = 6;
            this.number6Button.Text = "6";
            this.number6Button.UseVisualStyleBackColor = false;
            this.number6Button.Click += new System.EventHandler(this.number6_Click);
            // 
            // number5Button
            // 
            this.number5Button.BackColor = System.Drawing.Color.Tomato;
            this.number5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number5Button.Location = new System.Drawing.Point(77, 132);
            this.number5Button.Name = "number5Button";
            this.number5Button.Size = new System.Drawing.Size(60, 60);
            this.number5Button.TabIndex = 5;
            this.number5Button.Text = "5";
            this.number5Button.UseVisualStyleBackColor = false;
            this.number5Button.Click += new System.EventHandler(this.number5_Click);
            // 
            // number4Button
            // 
            this.number4Button.BackColor = System.Drawing.Color.Tomato;
            this.number4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number4Button.Location = new System.Drawing.Point(12, 132);
            this.number4Button.Name = "number4Button";
            this.number4Button.Size = new System.Drawing.Size(60, 60);
            this.number4Button.TabIndex = 4;
            this.number4Button.Text = "4";
            this.number4Button.UseVisualStyleBackColor = false;
            this.number4Button.Click += new System.EventHandler(this.number4_Click);
            // 
            // number9Button
            // 
            this.number9Button.BackColor = System.Drawing.Color.Tomato;
            this.number9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number9Button.Location = new System.Drawing.Point(142, 194);
            this.number9Button.Name = "number9Button";
            this.number9Button.Size = new System.Drawing.Size(60, 60);
            this.number9Button.TabIndex = 9;
            this.number9Button.Text = "9";
            this.number9Button.UseVisualStyleBackColor = false;
            this.number9Button.Click += new System.EventHandler(this.number9_Click);
            // 
            // number8Button
            // 
            this.number8Button.BackColor = System.Drawing.Color.Tomato;
            this.number8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number8Button.Location = new System.Drawing.Point(77, 194);
            this.number8Button.Name = "number8Button";
            this.number8Button.Size = new System.Drawing.Size(60, 60);
            this.number8Button.TabIndex = 8;
            this.number8Button.Text = "8";
            this.number8Button.UseVisualStyleBackColor = false;
            this.number8Button.Click += new System.EventHandler(this.number8_Click);
            // 
            // number7Button
            // 
            this.number7Button.BackColor = System.Drawing.Color.Tomato;
            this.number7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number7Button.Location = new System.Drawing.Point(12, 194);
            this.number7Button.Name = "number7Button";
            this.number7Button.Size = new System.Drawing.Size(60, 60);
            this.number7Button.TabIndex = 7;
            this.number7Button.Text = "7";
            this.number7Button.UseVisualStyleBackColor = false;
            this.number7Button.Click += new System.EventHandler(this.button9_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.Yellow;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.divide.Location = new System.Drawing.Point(207, 256);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(60, 60);
            this.divide.TabIndex = 10;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.button10_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Blue;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.equal.Location = new System.Drawing.Point(142, 256);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(60, 60);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // number0Button
            // 
            this.number0Button.BackColor = System.Drawing.Color.Tomato;
            this.number0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number0Button.Location = new System.Drawing.Point(77, 256);
            this.number0Button.Name = "number0Button";
            this.number0Button.Size = new System.Drawing.Size(60, 60);
            this.number0Button.TabIndex = 12;
            this.number0Button.Text = "0";
            this.number0Button.UseVisualStyleBackColor = false;
            this.number0Button.Click += new System.EventHandler(this.number0_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Red;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(12, 256);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(60, 60);
            this.clear.TabIndex = 11;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // impact
            // 
            this.impact.BackColor = System.Drawing.Color.Yellow;
            this.impact.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.impact.Location = new System.Drawing.Point(207, 194);
            this.impact.Name = "impact";
            this.impact.Size = new System.Drawing.Size(60, 60);
            this.impact.TabIndex = 14;
            this.impact.Text = "*";
            this.impact.UseVisualStyleBackColor = false;
            this.impact.Click += new System.EventHandler(this.impact_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Yellow;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minus.Location = new System.Drawing.Point(207, 132);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(60, 60);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Yellow;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plus.Location = new System.Drawing.Point(207, 70);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 60);
            this.plus.TabIndex = 16;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 325);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.impact);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.number0Button);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.number9Button);
            this.Controls.Add(this.number8Button);
            this.Controls.Add(this.number7Button);
            this.Controls.Add(this.number6Button);
            this.Controls.Add(this.number5Button);
            this.Controls.Add(this.number4Button);
            this.Controls.Add(this.number3Button);
            this.Controls.Add(this.number2Button);
            this.Controls.Add(this.number1Button);
            this.Controls.Add(this.screen1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label screen1;
        private System.Windows.Forms.Button number1Button;
        private System.Windows.Forms.Button number2Button;
        private System.Windows.Forms.Button number3Button;
        private System.Windows.Forms.Button number6Button;
        private System.Windows.Forms.Button number5Button;
        private System.Windows.Forms.Button number4Button;
        private System.Windows.Forms.Button number9Button;
        private System.Windows.Forms.Button number8Button;
        private System.Windows.Forms.Button number7Button;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button number0Button;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button impact;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
    }
}

