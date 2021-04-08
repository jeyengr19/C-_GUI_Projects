namespace Assignment_2_Arrays_APP
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
            this.txtBxFstArr = new System.Windows.Forms.TextBox();
            this.txtBxSecArr = new System.Windows.Forms.TextBox();
            this.lblFstArr = new System.Windows.Forms.Label();
            this.lblSecArr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDisp = new System.Windows.Forms.Button();
            this.lstFrsArr = new System.Windows.Forms.ListBox();
            this.lstSecArr = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBxFstArr
            // 
            this.txtBxFstArr.Location = new System.Drawing.Point(166, 122);
            this.txtBxFstArr.Name = "txtBxFstArr";
            this.txtBxFstArr.Size = new System.Drawing.Size(79, 22);
            this.txtBxFstArr.TabIndex = 0;
            // 
            // txtBxSecArr
            // 
            this.txtBxSecArr.Location = new System.Drawing.Point(460, 122);
            this.txtBxSecArr.Name = "txtBxSecArr";
            this.txtBxSecArr.Size = new System.Drawing.Size(75, 22);
            this.txtBxSecArr.TabIndex = 1;
            // 
            // lblFstArr
            // 
            this.lblFstArr.AutoSize = true;
            this.lblFstArr.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFstArr.Location = new System.Drawing.Point(72, 122);
            this.lblFstArr.Name = "lblFstArr";
            this.lblFstArr.Size = new System.Drawing.Size(88, 22);
            this.lblFstArr.TabIndex = 2;
            this.lblFstArr.Text = "Array 1: ";
            // 
            // lblSecArr
            // 
            this.lblSecArr.AutoSize = true;
            this.lblSecArr.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSecArr.Location = new System.Drawing.Point(366, 121);
            this.lblSecArr.Name = "lblSecArr";
            this.lblSecArr.Size = new System.Drawing.Size(88, 22);
            this.lblSecArr.TabIndex = 3;
            this.lblSecArr.Text = "Array 2: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Array Builder";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(202, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Element";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(326, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(442, 280);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 39);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset Array";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDisp
            // 
            this.btnDisp.Location = new System.Drawing.Point(202, 345);
            this.btnDisp.Name = "btnDisp";
            this.btnDisp.Size = new System.Drawing.Size(118, 40);
            this.btnDisp.TabIndex = 8;
            this.btnDisp.Text = "Display Arrays";
            this.btnDisp.UseVisualStyleBackColor = true;
            this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
            // 
            // lstFrsArr
            // 
            this.lstFrsArr.FormattingEnabled = true;
            this.lstFrsArr.ItemHeight = 16;
            this.lstFrsArr.Location = new System.Drawing.Point(170, 159);
            this.lstFrsArr.Name = "lstFrsArr";
            this.lstFrsArr.Size = new System.Drawing.Size(75, 84);
            this.lstFrsArr.TabIndex = 9;
            // 
            // lstSecArr
            // 
            this.lstSecArr.FormattingEnabled = true;
            this.lstSecArr.ItemHeight = 16;
            this.lstSecArr.Location = new System.Drawing.Point(460, 159);
            this.lstSecArr.Name = "lstSecArr";
            this.lstSecArr.Size = new System.Drawing.Size(75, 84);
            this.lstSecArr.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSecArr);
            this.Controls.Add(this.lstFrsArr);
            this.Controls.Add(this.btnDisp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSecArr);
            this.Controls.Add(this.lblFstArr);
            this.Controls.Add(this.txtBxSecArr);
            this.Controls.Add(this.txtBxFstArr);
            this.Name = "Form1";
            this.Text = "Arrays APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxFstArr;
        private System.Windows.Forms.TextBox txtBxSecArr;
        private System.Windows.Forms.Label lblFstArr;
        private System.Windows.Forms.Label lblSecArr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDisp;
        private System.Windows.Forms.ListBox lstFrsArr;
        private System.Windows.Forms.ListBox lstSecArr;
    }
}

