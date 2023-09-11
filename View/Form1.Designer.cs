namespace uni.home_work.parallel_distributed_computing.sorting_project
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
            this.sizeOfArrayToInputLabel = new System.Windows.Forms.Label();
            this.inputSizeOfArrayBox = new System.Windows.Forms.ComboBox();
            this.changeToSuccessivelySortingRadio = new System.Windows.Forms.RadioButton();
            this.changeToParallelySortingRadio = new System.Windows.Forms.RadioButton();
            this.bubbleSortTextLabel = new System.Windows.Forms.Label();
            this.shellSortTextLabel = new System.Windows.Forms.Label();
            this.quickSortTextLabel = new System.Windows.Forms.Label();
            this.bubbleSortElementsToViewTextBox = new System.Windows.Forms.RichTextBox();
            this.shellSortElementsToViewTextBox = new System.Windows.Forms.RichTextBox();
            this.quickSortElementsToViewTextBox = new System.Windows.Forms.RichTextBox();
            this.executeSortingButton = new System.Windows.Forms.Button();
            this.labelForComBubble = new System.Windows.Forms.Label();
            this.labelForComShell = new System.Windows.Forms.Label();
            this.labelForComQuick = new System.Windows.Forms.Label();
            this.labelForSwBubble = new System.Windows.Forms.Label();
            this.labelForSwShell = new System.Windows.Forms.Label();
            this.labelForSwQuick = new System.Windows.Forms.Label();
            this.labelForTimeBubble = new System.Windows.Forms.Label();
            this.labelForTimeShell = new System.Windows.Forms.Label();
            this.labelForTimeQuick = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeOfArrayToInputLabel
            // 
            this.sizeOfArrayToInputLabel.AutoSize = true;
            this.sizeOfArrayToInputLabel.Location = new System.Drawing.Point(13, 13);
            this.sizeOfArrayToInputLabel.Name = "sizeOfArrayToInputLabel";
            this.sizeOfArrayToInputLabel.Size = new System.Drawing.Size(102, 13);
            this.sizeOfArrayToInputLabel.TabIndex = 0;
            this.sizeOfArrayToInputLabel.Text = "Size of each vector:";
            // 
            // inputSizeOfArrayBox
            // 
            this.inputSizeOfArrayBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputSizeOfArrayBox.ForeColor = System.Drawing.Color.Black;
            this.inputSizeOfArrayBox.FormattingEnabled = true;
            this.inputSizeOfArrayBox.Items.AddRange(new object[] {
            "100",
            "10000",
            "50000",
            "100000",
            "500000"});
            this.inputSizeOfArrayBox.Location = new System.Drawing.Point(16, 41);
            this.inputSizeOfArrayBox.Name = "inputSizeOfArrayBox";
            this.inputSizeOfArrayBox.Size = new System.Drawing.Size(99, 21);
            this.inputSizeOfArrayBox.TabIndex = 1;
            this.inputSizeOfArrayBox.Text = "100";
            // 
            // changeToSuccessivelySortingRadio
            // 
            this.changeToSuccessivelySortingRadio.AutoSize = true;
            this.changeToSuccessivelySortingRadio.Location = new System.Drawing.Point(16, 68);
            this.changeToSuccessivelySortingRadio.Name = "changeToSuccessivelySortingRadio";
            this.changeToSuccessivelySortingRadio.Size = new System.Drawing.Size(87, 17);
            this.changeToSuccessivelySortingRadio.TabIndex = 2;
            this.changeToSuccessivelySortingRadio.TabStop = true;
            this.changeToSuccessivelySortingRadio.Text = "Successively";
            this.changeToSuccessivelySortingRadio.UseVisualStyleBackColor = true;
            // 
            // changeToParallelySortingRadio
            // 
            this.changeToParallelySortingRadio.AutoSize = true;
            this.changeToParallelySortingRadio.Location = new System.Drawing.Point(16, 91);
            this.changeToParallelySortingRadio.Name = "changeToParallelySortingRadio";
            this.changeToParallelySortingRadio.Size = new System.Drawing.Size(64, 17);
            this.changeToParallelySortingRadio.TabIndex = 3;
            this.changeToParallelySortingRadio.TabStop = true;
            this.changeToParallelySortingRadio.Text = "Parallely";
            this.changeToParallelySortingRadio.UseVisualStyleBackColor = true;
            // 
            // bubbleSortTextLabel
            // 
            this.bubbleSortTextLabel.AutoSize = true;
            this.bubbleSortTextLabel.Location = new System.Drawing.Point(157, 13);
            this.bubbleSortTextLabel.Name = "bubbleSortTextLabel";
            this.bubbleSortTextLabel.Size = new System.Drawing.Size(63, 13);
            this.bubbleSortTextLabel.TabIndex = 4;
            this.bubbleSortTextLabel.Text = "Bubble sort:";
            // 
            // shellSortTextLabel
            // 
            this.shellSortTextLabel.AutoSize = true;
            this.shellSortTextLabel.Location = new System.Drawing.Point(290, 13);
            this.shellSortTextLabel.Name = "shellSortTextLabel";
            this.shellSortTextLabel.Size = new System.Drawing.Size(53, 13);
            this.shellSortTextLabel.TabIndex = 5;
            this.shellSortTextLabel.Text = "Shell sort:";
            // 
            // quickSortTextLabel
            // 
            this.quickSortTextLabel.AutoSize = true;
            this.quickSortTextLabel.Location = new System.Drawing.Point(418, 13);
            this.quickSortTextLabel.Name = "quickSortTextLabel";
            this.quickSortTextLabel.Size = new System.Drawing.Size(58, 13);
            this.quickSortTextLabel.TabIndex = 6;
            this.quickSortTextLabel.Text = "Quick sort:";
            // 
            // bubbleSortElementsToViewTextBox
            // 
            this.bubbleSortElementsToViewTextBox.Location = new System.Drawing.Point(160, 30);
            this.bubbleSortElementsToViewTextBox.Name = "bubbleSortElementsToViewTextBox";
            this.bubbleSortElementsToViewTextBox.Size = new System.Drawing.Size(122, 267);
            this.bubbleSortElementsToViewTextBox.TabIndex = 7;
            this.bubbleSortElementsToViewTextBox.Text = "";
            // 
            // shellSortElementsToViewTextBox
            // 
            this.shellSortElementsToViewTextBox.Location = new System.Drawing.Point(293, 29);
            this.shellSortElementsToViewTextBox.Name = "shellSortElementsToViewTextBox";
            this.shellSortElementsToViewTextBox.Size = new System.Drawing.Size(122, 267);
            this.shellSortElementsToViewTextBox.TabIndex = 8;
            this.shellSortElementsToViewTextBox.Text = "";
            // 
            // quickSortElementsToViewTextBox
            // 
            this.quickSortElementsToViewTextBox.Location = new System.Drawing.Point(421, 30);
            this.quickSortElementsToViewTextBox.Name = "quickSortElementsToViewTextBox";
            this.quickSortElementsToViewTextBox.Size = new System.Drawing.Size(122, 267);
            this.quickSortElementsToViewTextBox.TabIndex = 9;
            this.quickSortElementsToViewTextBox.Text = "";
            // 
            // executeSortingButton
            // 
            this.executeSortingButton.Location = new System.Drawing.Point(16, 131);
            this.executeSortingButton.Name = "executeSortingButton";
            this.executeSortingButton.Size = new System.Drawing.Size(99, 23);
            this.executeSortingButton.TabIndex = 10;
            this.executeSortingButton.Text = "Start sorting";
            this.executeSortingButton.UseVisualStyleBackColor = true;
            this.executeSortingButton.Click += new System.EventHandler(this.executeSortingButton_Click);
            // 
            // labelForComBubble
            // 
            this.labelForComBubble.AutoSize = true;
            this.labelForComBubble.Location = new System.Drawing.Point(157, 304);
            this.labelForComBubble.Name = "labelForComBubble";
            this.labelForComBubble.Size = new System.Drawing.Size(42, 13);
            this.labelForComBubble.TabIndex = 11;
            this.labelForComBubble.Text = "com. = ";
            // 
            // labelForComShell
            // 
            this.labelForComShell.AutoSize = true;
            this.labelForComShell.Location = new System.Drawing.Point(290, 304);
            this.labelForComShell.Name = "labelForComShell";
            this.labelForComShell.Size = new System.Drawing.Size(42, 13);
            this.labelForComShell.TabIndex = 12;
            this.labelForComShell.Text = "com. = ";
            // 
            // labelForComQuick
            // 
            this.labelForComQuick.AutoSize = true;
            this.labelForComQuick.Location = new System.Drawing.Point(418, 304);
            this.labelForComQuick.Name = "labelForComQuick";
            this.labelForComQuick.Size = new System.Drawing.Size(42, 13);
            this.labelForComQuick.TabIndex = 13;
            this.labelForComQuick.Text = "com. = ";
            // 
            // labelForSwBubble
            // 
            this.labelForSwBubble.AutoSize = true;
            this.labelForSwBubble.Location = new System.Drawing.Point(157, 317);
            this.labelForSwBubble.Name = "labelForSwBubble";
            this.labelForSwBubble.Size = new System.Drawing.Size(35, 13);
            this.labelForSwBubble.TabIndex = 14;
            this.labelForSwBubble.Text = "sw. = ";
            // 
            // labelForSwShell
            // 
            this.labelForSwShell.AutoSize = true;
            this.labelForSwShell.Location = new System.Drawing.Point(290, 317);
            this.labelForSwShell.Name = "labelForSwShell";
            this.labelForSwShell.Size = new System.Drawing.Size(35, 13);
            this.labelForSwShell.TabIndex = 15;
            this.labelForSwShell.Text = "sw. = ";
            // 
            // labelForSwQuick
            // 
            this.labelForSwQuick.AutoSize = true;
            this.labelForSwQuick.Location = new System.Drawing.Point(418, 317);
            this.labelForSwQuick.Name = "labelForSwQuick";
            this.labelForSwQuick.Size = new System.Drawing.Size(35, 13);
            this.labelForSwQuick.TabIndex = 16;
            this.labelForSwQuick.Text = "sw. = ";
            // 
            // labelForTimeBubble
            // 
            this.labelForTimeBubble.AutoSize = true;
            this.labelForTimeBubble.Location = new System.Drawing.Point(157, 330);
            this.labelForTimeBubble.Name = "labelForTimeBubble";
            this.labelForTimeBubble.Size = new System.Drawing.Size(39, 13);
            this.labelForTimeBubble.TabIndex = 17;
            this.labelForTimeBubble.Text = "sec. = ";
            // 
            // labelForTimeShell
            // 
            this.labelForTimeShell.AutoSize = true;
            this.labelForTimeShell.Location = new System.Drawing.Point(290, 330);
            this.labelForTimeShell.Name = "labelForTimeShell";
            this.labelForTimeShell.Size = new System.Drawing.Size(39, 13);
            this.labelForTimeShell.TabIndex = 18;
            this.labelForTimeShell.Text = "sec. = ";
            // 
            // labelForTimeQuick
            // 
            this.labelForTimeQuick.AutoSize = true;
            this.labelForTimeQuick.Location = new System.Drawing.Point(418, 330);
            this.labelForTimeQuick.Name = "labelForTimeQuick";
            this.labelForTimeQuick.Size = new System.Drawing.Size(39, 13);
            this.labelForTimeQuick.TabIndex = 19;
            this.labelForTimeQuick.Text = "sec. = ";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 427);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(607, 22);
            this.statusStrip.TabIndex = 20;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(68, 17);
            this.statusLabel.Text = "Total time:  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(607, 449);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.labelForTimeQuick);
            this.Controls.Add(this.labelForTimeShell);
            this.Controls.Add(this.labelForTimeBubble);
            this.Controls.Add(this.labelForSwQuick);
            this.Controls.Add(this.labelForSwShell);
            this.Controls.Add(this.labelForSwBubble);
            this.Controls.Add(this.labelForComQuick);
            this.Controls.Add(this.labelForComShell);
            this.Controls.Add(this.labelForComBubble);
            this.Controls.Add(this.executeSortingButton);
            this.Controls.Add(this.quickSortElementsToViewTextBox);
            this.Controls.Add(this.shellSortElementsToViewTextBox);
            this.Controls.Add(this.bubbleSortElementsToViewTextBox);
            this.Controls.Add(this.quickSortTextLabel);
            this.Controls.Add(this.shellSortTextLabel);
            this.Controls.Add(this.bubbleSortTextLabel);
            this.Controls.Add(this.changeToParallelySortingRadio);
            this.Controls.Add(this.changeToSuccessivelySortingRadio);
            this.Controls.Add(this.inputSizeOfArrayBox);
            this.Controls.Add(this.sizeOfArrayToInputLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Sorting & Procecces";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sizeOfArrayToInputLabel;
        private System.Windows.Forms.ComboBox inputSizeOfArrayBox;
        private System.Windows.Forms.RadioButton changeToSuccessivelySortingRadio;
        private System.Windows.Forms.RadioButton changeToParallelySortingRadio;
        private System.Windows.Forms.Label bubbleSortTextLabel;
        private System.Windows.Forms.Label shellSortTextLabel;
        private System.Windows.Forms.Label quickSortTextLabel;
        private System.Windows.Forms.RichTextBox bubbleSortElementsToViewTextBox;
        private System.Windows.Forms.RichTextBox shellSortElementsToViewTextBox;
        private System.Windows.Forms.RichTextBox quickSortElementsToViewTextBox;
        private System.Windows.Forms.Button executeSortingButton;
        private System.Windows.Forms.Label labelForComBubble;
        private System.Windows.Forms.Label labelForComShell;
        private System.Windows.Forms.Label labelForComQuick;
        private System.Windows.Forms.Label labelForSwBubble;
        private System.Windows.Forms.Label labelForSwShell;
        private System.Windows.Forms.Label labelForSwQuick;
        private System.Windows.Forms.Label labelForTimeBubble;
        private System.Windows.Forms.Label labelForTimeShell;
        private System.Windows.Forms.Label labelForTimeQuick;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

