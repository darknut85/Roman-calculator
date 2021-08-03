
namespace Roman_calculator
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
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "I = 1"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "V = 5"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "X = 10"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "L = 50"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "C = 100"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "D = 500"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "D = 1000"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.buttonI = new System.Windows.Forms.Button();
            this.firstNumber = new System.Windows.Forms.Label();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.secondNumber = new System.Windows.Forms.Label();
            this.Switch = new System.Windows.Forms.Button();
            this.labelOP = new System.Windows.Forms.Label();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.labelEqual = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonI
            // 
            this.buttonI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonI.Location = new System.Drawing.Point(263, 369);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(54, 49);
            this.buttonI.TabIndex = 0;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // firstNumber
            // 
            this.firstNumber.AutoSize = true;
            this.firstNumber.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.firstNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumber.Location = new System.Drawing.Point(329, 9);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(24, 33);
            this.firstNumber.TabIndex = 1;
            this.firstNumber.Text = ".";
            this.firstNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstNumber.Click += new System.EventHandler(this.firstNumber_Click);
            // 
            // buttonV
            // 
            this.buttonV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonV.Location = new System.Drawing.Point(263, 314);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(54, 49);
            this.buttonV.TabIndex = 2;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Click += new System.EventHandler(this.buttonV_Click);
            // 
            // buttonX
            // 
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.Location = new System.Drawing.Point(263, 259);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(54, 49);
            this.buttonX.TabIndex = 3;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(487, 259);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(54, 49);
            this.buttonPlus.TabIndex = 4;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonL
            // 
            this.buttonL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonL.Location = new System.Drawing.Point(323, 369);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(54, 49);
            this.buttonL.TabIndex = 5;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(323, 314);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(54, 49);
            this.buttonC.TabIndex = 6;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.Location = new System.Drawing.Point(323, 259);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(54, 49);
            this.buttonD.TabIndex = 7;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonM
            // 
            this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonM.Location = new System.Drawing.Point(383, 369);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(54, 49);
            this.buttonM.TabIndex = 8;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // secondNumber
            // 
            this.secondNumber.AutoSize = true;
            this.secondNumber.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.secondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumber.Location = new System.Drawing.Point(329, 99);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(22, 31);
            this.secondNumber.TabIndex = 9;
            this.secondNumber.Text = ".";
            this.secondNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.secondNumber.Click += new System.EventHandler(this.secondNumber_Click);
            // 
            // Switch
            // 
            this.Switch.Location = new System.Drawing.Point(383, 259);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(54, 49);
            this.Switch.TabIndex = 10;
            this.Switch.Text = "Switch";
            this.Switch.UseVisualStyleBackColor = true;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // labelOP
            // 
            this.labelOP.AutoSize = true;
            this.labelOP.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOP.Location = new System.Drawing.Point(329, 54);
            this.labelOP.Name = "labelOP";
            this.labelOP.Size = new System.Drawing.Size(22, 31);
            this.labelOP.TabIndex = 11;
            this.labelOP.Text = ".";
            this.labelOP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOP.Click += new System.EventHandler(this.labelOP_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(487, 314);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(54, 49);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(547, 259);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(54, 49);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(547, 314);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(54, 49);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // labelEqual
            // 
            this.labelEqual.AutoSize = true;
            this.labelEqual.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEqual.Location = new System.Drawing.Point(329, 144);
            this.labelEqual.Name = "labelEqual";
            this.labelEqual.Size = new System.Drawing.Size(30, 31);
            this.labelEqual.TabIndex = 15;
            this.labelEqual.Text = "=";
            this.labelEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEqual.Click += new System.EventHandler(this.labelEqual_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.Location = new System.Drawing.Point(329, 189);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(22, 31);
            this.labelAnswer.TabIndex = 16;
            this.labelAnswer.Text = ".";
            this.labelAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAnswer.Click += new System.EventHandler(this.labelAnswer_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(487, 369);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(54, 49);
            this.buttonEqual.TabIndex = 17;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(547, 369);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(54, 49);
            this.buttonReset.TabIndex = 19;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(383, 314);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(54, 49);
            this.buttonUndo.TabIndex = 20;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.listView1.Location = new System.Drawing.Point(76, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(104, 340);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelEqual);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.labelOP);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.buttonI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonPlus;
        public System.Windows.Forms.Label firstNumber;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonM;
        public System.Windows.Forms.Label secondNumber;
        private System.Windows.Forms.Button Switch;
        public System.Windows.Forms.Label labelOP;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        public System.Windows.Forms.Label labelEqual;
        public System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.ListView listView1;
    }
}

