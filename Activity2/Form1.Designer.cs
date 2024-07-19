namespace Activity2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.buttonAddFirst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddLast = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumOfNodes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNodePosition = new System.Windows.Forms.TextBox();
            this.buttonAddBefore = new System.Windows.Forms.Button();
            this.buttonAddAfter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 290);
            this.listBox1.TabIndex = 0;
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Location = new System.Drawing.Point(149, 55);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarName.TabIndex = 1;
            // 
            // buttonAddFirst
            // 
            this.buttonAddFirst.Location = new System.Drawing.Point(149, 81);
            this.buttonAddFirst.Name = "buttonAddFirst";
            this.buttonAddFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFirst.TabIndex = 2;
            this.buttonAddFirst.Text = "Add First";
            this.buttonAddFirst.UseVisualStyleBackColor = true;
            this.buttonAddFirst.Click += new System.EventHandler(this.buttonAddFirst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Name";
            // 
            // buttonAddLast
            // 
            this.buttonAddLast.Location = new System.Drawing.Point(149, 110);
            this.buttonAddLast.Name = "buttonAddLast";
            this.buttonAddLast.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLast.TabIndex = 4;
            this.buttonAddLast.Text = "Add Last";
            this.buttonAddLast.UseVisualStyleBackColor = true;
            this.buttonAddLast.Click += new System.EventHandler(this.buttonAddLast_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(149, 258);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(149, 287);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of nodes: ";
            // 
            // textBoxNumOfNodes
            // 
            this.textBoxNumOfNodes.Location = new System.Drawing.Point(329, 284);
            this.textBoxNumOfNodes.Name = "textBoxNumOfNodes";
            this.textBoxNumOfNodes.Size = new System.Drawing.Size(57, 20);
            this.textBoxNumOfNodes.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Node Position";
            // 
            // textBoxNodePosition
            // 
            this.textBoxNodePosition.Location = new System.Drawing.Point(329, 55);
            this.textBoxNodePosition.Name = "textBoxNodePosition";
            this.textBoxNodePosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxNodePosition.TabIndex = 10;
            // 
            // buttonAddBefore
            // 
            this.buttonAddBefore.Location = new System.Drawing.Point(329, 81);
            this.buttonAddBefore.Name = "buttonAddBefore";
            this.buttonAddBefore.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBefore.TabIndex = 11;
            this.buttonAddBefore.Text = "Add Before";
            this.buttonAddBefore.UseVisualStyleBackColor = true;
            this.buttonAddBefore.Click += new System.EventHandler(this.buttonAddBefore_Click);
            // 
            // buttonAddAfter
            // 
            this.buttonAddAfter.Location = new System.Drawing.Point(329, 110);
            this.buttonAddAfter.Name = "buttonAddAfter";
            this.buttonAddAfter.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAfter.TabIndex = 12;
            this.buttonAddAfter.Text = "Add After";
            this.buttonAddAfter.UseVisualStyleBackColor = true;
            this.buttonAddAfter.Click += new System.EventHandler(this.buttonAddAfter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 342);
            this.Controls.Add(this.buttonAddAfter);
            this.Controls.Add(this.buttonAddBefore);
            this.Controls.Add(this.textBoxNodePosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumOfNodes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddLast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddFirst);
            this.Controls.Add(this.textBoxCarName);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxCarName;
        private System.Windows.Forms.Button buttonAddFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddLast;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumOfNodes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNodePosition;
        private System.Windows.Forms.Button buttonAddBefore;
        private System.Windows.Forms.Button buttonAddAfter;
    }
}

