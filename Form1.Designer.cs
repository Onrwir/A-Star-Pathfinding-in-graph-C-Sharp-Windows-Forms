
namespace Astar_search_algorithm
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
            this.foundPath_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.searchPath_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addEdge_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edgeCost_NUP = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edgeStart_cb = new System.Windows.Forms.ComboBox();
            this.edgeEnd_cb = new System.Windows.Forms.ComboBox();
            this.addVertex_button = new System.Windows.Forms.Button();
            this.vertexName_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vertexY_NUP = new System.Windows.Forms.NumericUpDown();
            this.vertexX_NUP = new System.Windows.Forms.NumericUpDown();
            this.pathStart_cb = new System.Windows.Forms.ComboBox();
            this.pathEnd_cb = new System.Windows.Forms.ComboBox();
            this.testData_button = new System.Windows.Forms.Button();
            this.clearAllData_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edgeCost_NUP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vertexY_NUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexX_NUP)).BeginInit();
            this.SuspendLayout();
            // 
            // foundPath_tb
            // 
            this.foundPath_tb.Location = new System.Drawing.Point(524, 47);
            this.foundPath_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foundPath_tb.Multiline = true;
            this.foundPath_tb.Name = "foundPath_tb";
            this.foundPath_tb.Size = new System.Drawing.Size(520, 114);
            this.foundPath_tb.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "FOUND PATH:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "End";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Start";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Search path";
            // 
            // searchPath_Button
            // 
            this.searchPath_Button.Location = new System.Drawing.Point(229, 121);
            this.searchPath_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchPath_Button.Name = "searchPath_Button";
            this.searchPath_Button.Size = new System.Drawing.Size(251, 39);
            this.searchPath_Button.TabIndex = 16;
            this.searchPath_Button.Text = "Search";
            this.searchPath_Button.UseVisualStyleBackColor = true;
            this.searchPath_Button.Click += new System.EventHandler(this.searchPath_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(229, 167);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 513);
            this.panel1.TabIndex = 42;
            // 
            // addEdge_button
            // 
            this.addEdge_button.Location = new System.Drawing.Point(17, 165);
            this.addEdge_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEdge_button.Name = "addEdge_button";
            this.addEdge_button.Size = new System.Drawing.Size(141, 39);
            this.addEdge_button.TabIndex = 50;
            this.addEdge_button.Text = "Add Edge";
            this.addEdge_button.UseVisualStyleBackColor = true;
            this.addEdge_button.Click += new System.EventHandler(this.addEdge_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edgeCost_NUP);
            this.groupBox1.Controls.Add(this.addEdge_button);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edgeStart_cb);
            this.groupBox1.Controls.Add(this.edgeEnd_cb);
            this.groupBox1.Location = new System.Drawing.Point(21, 277);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(183, 231);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EDGE";
            // 
            // edgeCost_NUP
            // 
            this.edgeCost_NUP.Location = new System.Drawing.Point(28, 137);
            this.edgeCost_NUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edgeCost_NUP.Name = "edgeCost_NUP";
            this.edgeCost_NUP.Size = new System.Drawing.Size(121, 22);
            this.edgeCost_NUP.TabIndex = 57;
            this.edgeCost_NUP.Minimum = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Start";
            // 
            // edgeStart_cb
            // 
            this.edgeStart_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edgeStart_cb.FormattingEnabled = true;
            this.edgeStart_cb.Location = new System.Drawing.Point(28, 43);
            this.edgeStart_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edgeStart_cb.Name = "edgeStart_cb";
            this.edgeStart_cb.Size = new System.Drawing.Size(121, 24);
            this.edgeStart_cb.Sorted = true;
            this.edgeStart_cb.TabIndex = 50;
            // 
            // edgeEnd_cb
            // 
            this.edgeEnd_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edgeEnd_cb.FormattingEnabled = true;
            this.edgeEnd_cb.Location = new System.Drawing.Point(28, 89);
            this.edgeEnd_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edgeEnd_cb.Name = "edgeEnd_cb";
            this.edgeEnd_cb.Size = new System.Drawing.Size(121, 24);
            this.edgeEnd_cb.Sorted = true;
            this.edgeEnd_cb.TabIndex = 51;
            // 
            // addVertex_button
            // 
            this.addVertex_button.Location = new System.Drawing.Point(19, 134);
            this.addVertex_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVertex_button.Name = "addVertex_button";
            this.addVertex_button.Size = new System.Drawing.Size(141, 39);
            this.addVertex_button.TabIndex = 43;
            this.addVertex_button.Text = "Add Vertex";
            this.addVertex_button.UseVisualStyleBackColor = true;
            this.addVertex_button.Click += new System.EventHandler(this.addVertex_button_Click);
            // 
            // vertexName_tb
            // 
            this.vertexName_tb.Location = new System.Drawing.Point(65, 36);
            this.vertexName_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vertexName_tb.Name = "vertexName_tb";
            this.vertexName_tb.Size = new System.Drawing.Size(96, 22);
            this.vertexName_tb.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vertexY_NUP);
            this.groupBox2.Controls.Add(this.vertexX_NUP);
            this.groupBox2.Controls.Add(this.vertexName_tb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addVertex_button);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(183, 225);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VERTEX";
            // 
            // vertexY_NUP
            // 
            this.vertexY_NUP.Location = new System.Drawing.Point(65, 97);
            this.vertexY_NUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vertexY_NUP.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.vertexY_NUP.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.vertexY_NUP.Name = "vertexY_NUP";
            this.vertexY_NUP.Size = new System.Drawing.Size(96, 22);
            this.vertexY_NUP.TabIndex = 56;
            // 
            // vertexX_NUP
            // 
            this.vertexX_NUP.Location = new System.Drawing.Point(65, 65);
            this.vertexX_NUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vertexX_NUP.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.vertexX_NUP.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.vertexX_NUP.Name = "vertexX_NUP";
            this.vertexX_NUP.Size = new System.Drawing.Size(96, 22);
            this.vertexX_NUP.TabIndex = 55;
            // 
            // pathStart_cb
            // 
            this.pathStart_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pathStart_cb.FormattingEnabled = true;
            this.pathStart_cb.Location = new System.Drawing.Point(293, 46);
            this.pathStart_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathStart_cb.Name = "pathStart_cb";
            this.pathStart_cb.Size = new System.Drawing.Size(149, 24);
            this.pathStart_cb.Sorted = true;
            this.pathStart_cb.TabIndex = 55;
            // 
            // pathEnd_cb
            // 
            this.pathEnd_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pathEnd_cb.FormattingEnabled = true;
            this.pathEnd_cb.Location = new System.Drawing.Point(293, 81);
            this.pathEnd_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathEnd_cb.Name = "pathEnd_cb";
            this.pathEnd_cb.Size = new System.Drawing.Size(149, 24);
            this.pathEnd_cb.Sorted = true;
            this.pathEnd_cb.TabIndex = 58;
            // 
            // testData_button
            // 
            this.testData_button.Location = new System.Drawing.Point(21, 522);
            this.testData_button.Name = "testData_button";
            this.testData_button.Size = new System.Drawing.Size(183, 53);
            this.testData_button.TabIndex = 59;
            this.testData_button.Text = "Render Test Data";
            this.testData_button.UseVisualStyleBackColor = true;
            this.testData_button.Click += new System.EventHandler(this.testData_button_Click);
            // 
            // clearAllData_button
            // 
            this.clearAllData_button.Location = new System.Drawing.Point(21, 601);
            this.clearAllData_button.Name = "clearAllData_button";
            this.clearAllData_button.Size = new System.Drawing.Size(183, 53);
            this.clearAllData_button.TabIndex = 60;
            this.clearAllData_button.Text = "Clear All Data";
            this.clearAllData_button.UseVisualStyleBackColor = true;
            this.clearAllData_button.Click += new System.EventHandler(this.clearAllData_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 692);
            this.Controls.Add(this.clearAllData_button);
            this.Controls.Add(this.testData_button);
            this.Controls.Add(this.pathEnd_cb);
            this.Controls.Add(this.pathStart_cb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.foundPath_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchPath_Button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edgeCost_NUP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vertexY_NUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexX_NUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox foundPath_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button searchPath_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addVertex_button;
        private System.Windows.Forms.TextBox vertexName_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox edgeStart_cb;
        private System.Windows.Forms.Button addEdge_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox edgeEnd_cb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown vertexX_NUP;
        private System.Windows.Forms.NumericUpDown vertexY_NUP;
        private System.Windows.Forms.NumericUpDown edgeCost_NUP;
        private System.Windows.Forms.ComboBox pathStart_cb;
        private System.Windows.Forms.ComboBox pathEnd_cb;
        private System.Windows.Forms.Button testData_button;
        private System.Windows.Forms.Button clearAllData_button;
    }
}

