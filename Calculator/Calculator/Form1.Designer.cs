namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pad1 = new System.Windows.Forms.Button();
            this.pad4 = new System.Windows.Forms.Button();
            this.pad8 = new System.Windows.Forms.Button();
            this.pad5 = new System.Windows.Forms.Button();
            this.pad2 = new System.Windows.Forms.Button();
            this.pad7 = new System.Windows.Forms.Button();
            this.pad9 = new System.Windows.Forms.Button();
            this.pad6 = new System.Windows.Forms.Button();
            this.pad3 = new System.Windows.Forms.Button();
            this.operationSubstract = new System.Windows.Forms.Button();
            this.operationResult = new System.Windows.Forms.Button();
            this.operationAdd = new System.Windows.Forms.Button();
            this.operationMultiply = new System.Windows.Forms.Button();
            this.operationClear = new System.Windows.Forms.Button();
            this.operationDivide = new System.Windows.Forms.Button();
            this.operationClearEntry = new System.Windows.Forms.Button();
            this.padPoint = new System.Windows.Forms.Button();
            this.pad0 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.operationSqrt = new System.Windows.Forms.Button();
            this.operationPercent = new System.Windows.Forms.Button();
            this.operationInverse = new System.Windows.Forms.Button();
            this.operationMemoryStore = new System.Windows.Forms.Button();
            this.operationMemoryRecall = new System.Windows.Forms.Button();
            this.operationMemoryClear = new System.Windows.Forms.Button();
            this.operationMemoryAdd = new System.Windows.Forms.Button();
            this.memory = new System.Windows.Forms.TextBox();
            this.signChanger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pad1
            // 
            this.pad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pad1.Location = new System.Drawing.Point(58, 187);
            this.pad1.Name = "pad1";
            this.pad1.Size = new System.Drawing.Size(40, 40);
            this.pad1.TabIndex = 0;
            this.pad1.Text = "1";
            this.pad1.UseVisualStyleBackColor = true;
            this.pad1.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad4
            // 
            this.pad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pad4.Location = new System.Drawing.Point(58, 141);
            this.pad4.Name = "pad4";
            this.pad4.Size = new System.Drawing.Size(40, 40);
            this.pad4.TabIndex = 1;
            this.pad4.Text = "4";
            this.pad4.UseVisualStyleBackColor = true;
            this.pad4.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad8
            // 
            this.pad8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pad8.Location = new System.Drawing.Point(104, 95);
            this.pad8.Name = "pad8";
            this.pad8.Size = new System.Drawing.Size(40, 40);
            this.pad8.TabIndex = 2;
            this.pad8.Text = "8";
            this.pad8.UseVisualStyleBackColor = true;
            this.pad8.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad5
            // 
            this.pad5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pad5.Location = new System.Drawing.Point(104, 141);
            this.pad5.Name = "pad5";
            this.pad5.Size = new System.Drawing.Size(40, 40);
            this.pad5.TabIndex = 3;
            this.pad5.Text = "5";
            this.pad5.UseVisualStyleBackColor = true;
            this.pad5.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad2
            // 
            this.pad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pad2.Location = new System.Drawing.Point(105, 187);
            this.pad2.Name = "pad2";
            this.pad2.Size = new System.Drawing.Size(40, 40);
            this.pad2.TabIndex = 4;
            this.pad2.Text = "2";
            this.pad2.UseVisualStyleBackColor = true;
            this.pad2.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad7
            // 
            this.pad7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pad7.Location = new System.Drawing.Point(58, 95);
            this.pad7.Name = "pad7";
            this.pad7.Size = new System.Drawing.Size(40, 40);
            this.pad7.TabIndex = 5;
            this.pad7.Text = "7";
            this.pad7.UseVisualStyleBackColor = true;
            this.pad7.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad9
            // 
            this.pad9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pad9.Location = new System.Drawing.Point(150, 95);
            this.pad9.Name = "pad9";
            this.pad9.Size = new System.Drawing.Size(40, 40);
            this.pad9.TabIndex = 6;
            this.pad9.Text = "9";
            this.pad9.UseVisualStyleBackColor = true;
            this.pad9.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad6
            // 
            this.pad6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pad6.Location = new System.Drawing.Point(150, 141);
            this.pad6.Name = "pad6";
            this.pad6.Size = new System.Drawing.Size(40, 40);
            this.pad6.TabIndex = 7;
            this.pad6.Text = "6";
            this.pad6.UseVisualStyleBackColor = true;
            this.pad6.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad3
            // 
            this.pad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pad3.Location = new System.Drawing.Point(150, 187);
            this.pad3.Name = "pad3";
            this.pad3.Size = new System.Drawing.Size(40, 40);
            this.pad3.TabIndex = 8;
            this.pad3.Text = "3";
            this.pad3.UseVisualStyleBackColor = true;
            this.pad3.Click += new System.EventHandler(this.pad_Click);
            // 
            // operationSubstract
            // 
            this.operationSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationSubstract.Location = new System.Drawing.Point(196, 187);
            this.operationSubstract.Name = "operationSubstract";
            this.operationSubstract.Size = new System.Drawing.Size(40, 40);
            this.operationSubstract.TabIndex = 10;
            this.operationSubstract.Text = "-";
            this.operationSubstract.UseVisualStyleBackColor = true;
            this.operationSubstract.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationResult
            // 
            this.operationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationResult.Location = new System.Drawing.Point(242, 233);
            this.operationResult.Name = "operationResult";
            this.operationResult.Size = new System.Drawing.Size(40, 40);
            this.operationResult.TabIndex = 11;
            this.operationResult.Text = "=";
            this.operationResult.UseVisualStyleBackColor = true;
            this.operationResult.Click += new System.EventHandler(this.operationResult_Click);
            // 
            // operationAdd
            // 
            this.operationAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationAdd.Location = new System.Drawing.Point(196, 233);
            this.operationAdd.Name = "operationAdd";
            this.operationAdd.Size = new System.Drawing.Size(40, 40);
            this.operationAdd.TabIndex = 12;
            this.operationAdd.Text = "+";
            this.operationAdd.UseVisualStyleBackColor = true;
            this.operationAdd.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationMultiply
            // 
            this.operationMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationMultiply.Location = new System.Drawing.Point(196, 141);
            this.operationMultiply.Name = "operationMultiply";
            this.operationMultiply.Size = new System.Drawing.Size(40, 40);
            this.operationMultiply.TabIndex = 13;
            this.operationMultiply.Text = "*";
            this.operationMultiply.UseVisualStyleBackColor = true;
            this.operationMultiply.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationClear
            // 
            this.operationClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationClear.Location = new System.Drawing.Point(82, 49);
            this.operationClear.Name = "operationClear";
            this.operationClear.Size = new System.Drawing.Size(48, 40);
            this.operationClear.TabIndex = 14;
            this.operationClear.Text = "C";
            this.operationClear.UseVisualStyleBackColor = true;
            this.operationClear.Click += new System.EventHandler(this.operationClear_Click);
            // 
            // operationDivide
            // 
            this.operationDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationDivide.Location = new System.Drawing.Point(196, 95);
            this.operationDivide.Name = "operationDivide";
            this.operationDivide.Size = new System.Drawing.Size(40, 40);
            this.operationDivide.TabIndex = 19;
            this.operationDivide.Text = "/";
            this.operationDivide.UseVisualStyleBackColor = true;
            this.operationDivide.Click += new System.EventHandler(this.operation_Click);
            // 
            // operationClearEntry
            // 
            this.operationClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationClearEntry.Location = new System.Drawing.Point(136, 49);
            this.operationClearEntry.Name = "operationClearEntry";
            this.operationClearEntry.Size = new System.Drawing.Size(47, 40);
            this.operationClearEntry.TabIndex = 18;
            this.operationClearEntry.Text = "CE";
            this.operationClearEntry.UseVisualStyleBackColor = true;
            this.operationClearEntry.Click += new System.EventHandler(this.operationClear_Click);
            // 
            // padPoint
            // 
            this.padPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.padPoint.Location = new System.Drawing.Point(150, 233);
            this.padPoint.Name = "padPoint";
            this.padPoint.Size = new System.Drawing.Size(40, 40);
            this.padPoint.TabIndex = 17;
            this.padPoint.Text = ",";
            this.padPoint.UseVisualStyleBackColor = true;
            this.padPoint.Click += new System.EventHandler(this.pad_Click);
            // 
            // pad0
            // 
            this.pad0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pad0.Location = new System.Drawing.Point(58, 233);
            this.pad0.Name = "pad0";
            this.pad0.Size = new System.Drawing.Size(86, 40);
            this.pad0.TabIndex = 15;
            this.pad0.Text = "0";
            this.pad0.UseVisualStyleBackColor = true;
            this.pad0.Click += new System.EventHandler(this.pad_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(270, 22);
            this.display.TabIndex = 20;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(189, 49);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(47, 40);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.operationClear_Click);
            // 
            // operationSqrt
            // 
            this.operationSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationSqrt.Location = new System.Drawing.Point(242, 95);
            this.operationSqrt.Name = "operationSqrt";
            this.operationSqrt.Size = new System.Drawing.Size(40, 40);
            this.operationSqrt.TabIndex = 23;
            this.operationSqrt.Text = "sqrt";
            this.operationSqrt.UseVisualStyleBackColor = true;
            this.operationSqrt.Click += new System.EventHandler(this.operationResultSpecial_Click);
            // 
            // operationPercent
            // 
            this.operationPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationPercent.Location = new System.Drawing.Point(242, 141);
            this.operationPercent.Name = "operationPercent";
            this.operationPercent.Size = new System.Drawing.Size(40, 40);
            this.operationPercent.TabIndex = 24;
            this.operationPercent.Text = "%";
            this.operationPercent.UseVisualStyleBackColor = true;
            this.operationPercent.Click += new System.EventHandler(this.operationResultSpecial_Click);
            // 
            // operationInverse
            // 
            this.operationInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationInverse.Location = new System.Drawing.Point(242, 187);
            this.operationInverse.Name = "operationInverse";
            this.operationInverse.Size = new System.Drawing.Size(40, 40);
            this.operationInverse.TabIndex = 25;
            this.operationInverse.Text = "1/x";
            this.operationInverse.UseVisualStyleBackColor = true;
            this.operationInverse.Click += new System.EventHandler(this.operationResultSpecial_Click);
            // 
            // operationMemoryStore
            // 
            this.operationMemoryStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationMemoryStore.Location = new System.Drawing.Point(12, 187);
            this.operationMemoryStore.Name = "operationMemoryStore";
            this.operationMemoryStore.Size = new System.Drawing.Size(40, 40);
            this.operationMemoryStore.TabIndex = 29;
            this.operationMemoryStore.Text = "MS";
            this.operationMemoryStore.UseVisualStyleBackColor = true;
            this.operationMemoryStore.Click += new System.EventHandler(this.operationMemory_Click);
            // 
            // operationMemoryRecall
            // 
            this.operationMemoryRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationMemoryRecall.Location = new System.Drawing.Point(12, 141);
            this.operationMemoryRecall.Name = "operationMemoryRecall";
            this.operationMemoryRecall.Size = new System.Drawing.Size(40, 40);
            this.operationMemoryRecall.TabIndex = 28;
            this.operationMemoryRecall.Text = "MR";
            this.operationMemoryRecall.UseVisualStyleBackColor = true;
            this.operationMemoryRecall.Click += new System.EventHandler(this.operationMemory_Click);
            // 
            // operationMemoryClear
            // 
            this.operationMemoryClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationMemoryClear.Location = new System.Drawing.Point(12, 96);
            this.operationMemoryClear.Name = "operationMemoryClear";
            this.operationMemoryClear.Size = new System.Drawing.Size(40, 39);
            this.operationMemoryClear.TabIndex = 27;
            this.operationMemoryClear.Text = "MC";
            this.operationMemoryClear.UseVisualStyleBackColor = true;
            this.operationMemoryClear.Click += new System.EventHandler(this.operationMemory_Click);
            // 
            // operationMemoryAdd
            // 
            this.operationMemoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationMemoryAdd.Location = new System.Drawing.Point(12, 233);
            this.operationMemoryAdd.Name = "operationMemoryAdd";
            this.operationMemoryAdd.Size = new System.Drawing.Size(40, 40);
            this.operationMemoryAdd.TabIndex = 26;
            this.operationMemoryAdd.Text = "M+";
            this.operationMemoryAdd.UseVisualStyleBackColor = true;
            this.operationMemoryAdd.Click += new System.EventHandler(this.operationMemory_Click);
            // 
            // memory
            // 
            this.memory.Location = new System.Drawing.Point(12, 49);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(53, 20);
            this.memory.TabIndex = 30;
            this.memory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // signChanger
            // 
            this.signChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signChanger.Location = new System.Drawing.Point(242, 49);
            this.signChanger.Name = "signChanger";
            this.signChanger.Size = new System.Drawing.Size(40, 40);
            this.signChanger.TabIndex = 31;
            this.signChanger.Text = "+/-";
            this.signChanger.UseVisualStyleBackColor = true;
            this.signChanger.Click += new System.EventHandler(this.operationResultSpecial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 285);
            this.Controls.Add(this.signChanger);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.operationMemoryStore);
            this.Controls.Add(this.operationMemoryRecall);
            this.Controls.Add(this.operationMemoryClear);
            this.Controls.Add(this.operationMemoryAdd);
            this.Controls.Add(this.operationInverse);
            this.Controls.Add(this.operationPercent);
            this.Controls.Add(this.operationSqrt);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.display);
            this.Controls.Add(this.operationDivide);
            this.Controls.Add(this.operationClearEntry);
            this.Controls.Add(this.padPoint);
            this.Controls.Add(this.pad0);
            this.Controls.Add(this.operationClear);
            this.Controls.Add(this.operationMultiply);
            this.Controls.Add(this.operationAdd);
            this.Controls.Add(this.operationResult);
            this.Controls.Add(this.operationSubstract);
            this.Controls.Add(this.pad3);
            this.Controls.Add(this.pad6);
            this.Controls.Add(this.pad9);
            this.Controls.Add(this.pad7);
            this.Controls.Add(this.pad2);
            this.Controls.Add(this.pad5);
            this.Controls.Add(this.pad8);
            this.Controls.Add(this.pad4);
            this.Controls.Add(this.pad1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pad1;
        private System.Windows.Forms.Button pad4;
        private System.Windows.Forms.Button pad8;
        private System.Windows.Forms.Button pad5;
        private System.Windows.Forms.Button pad2;
        private System.Windows.Forms.Button pad7;
        private System.Windows.Forms.Button pad9;
        private System.Windows.Forms.Button pad6;
        private System.Windows.Forms.Button pad3;
        private System.Windows.Forms.Button operationSubstract;
        private System.Windows.Forms.Button operationResult;
        private System.Windows.Forms.Button operationAdd;
        private System.Windows.Forms.Button operationMultiply;
        private System.Windows.Forms.Button operationClear;
        private System.Windows.Forms.Button operationDivide;
        private System.Windows.Forms.Button operationClearEntry;
        private System.Windows.Forms.Button padPoint;
        private System.Windows.Forms.Button pad0;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button operationSqrt;
        private System.Windows.Forms.Button operationPercent;
        private System.Windows.Forms.Button operationInverse;
        private System.Windows.Forms.Button operationMemoryStore;
        private System.Windows.Forms.Button operationMemoryRecall;
        private System.Windows.Forms.Button operationMemoryClear;
        private System.Windows.Forms.Button operationMemoryAdd;
        private System.Windows.Forms.TextBox memory;
        private System.Windows.Forms.Button signChanger;
    }
}

