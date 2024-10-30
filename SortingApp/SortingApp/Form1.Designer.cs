namespace SortingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonBubbleSort = new Button();
            textBoxInput = new TextBox();
            listBoxResults = new ListBox();
            buttonQuickSort = new Button();
            buttonMergeSort = new Button();
            buttonInsertionSort = new Button();
            buttonCountingSort = new Button();
            buttonSelectionSort = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonBubbleSort
            // 
            buttonBubbleSort.Location = new Point(12, 45);
            buttonBubbleSort.Name = "buttonBubbleSort";
            buttonBubbleSort.Size = new Size(94, 29);
            buttonBubbleSort.TabIndex = 0;
            buttonBubbleSort.Text = "BubbleSort";
            buttonBubbleSort.UseVisualStyleBackColor = true;
            buttonBubbleSort.Click += buttonBubbleSort_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 12);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(125, 27);
            textBoxInput.TabIndex = 1;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 20;
            listBoxResults.Location = new Point(12, 80);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(150, 104);
            listBoxResults.TabIndex = 2;
            // 
            // buttonQuickSort
            // 
            buttonQuickSort.Location = new Point(112, 45);
            buttonQuickSort.Name = "buttonQuickSort";
            buttonQuickSort.Size = new Size(94, 29);
            buttonQuickSort.TabIndex = 3;
            buttonQuickSort.Text = "QuickSort";
            buttonQuickSort.UseVisualStyleBackColor = true;
            buttonQuickSort.Click += buttonQuickSort_Click;
            // 
            // buttonMergeSort
            // 
            buttonMergeSort.Location = new Point(212, 45);
            buttonMergeSort.Name = "buttonMergeSort";
            buttonMergeSort.Size = new Size(94, 29);
            buttonMergeSort.TabIndex = 4;
            buttonMergeSort.Text = "MergeSort";
            buttonMergeSort.UseVisualStyleBackColor = true;
            buttonMergeSort.Click += buttonMergeSort_Click;
            // 
            // buttonInsertionSort
            // 
            buttonInsertionSort.Location = new Point(312, 45);
            buttonInsertionSort.Name = "buttonInsertionSort";
            buttonInsertionSort.Size = new Size(94, 29);
            buttonInsertionSort.TabIndex = 5;
            buttonInsertionSort.Text = "Insertion";
            buttonInsertionSort.UseVisualStyleBackColor = true;
            buttonInsertionSort.Click += buttonInsertionSort_Click;
            // 
            // buttonCountingSort
            // 
            buttonCountingSort.Location = new Point(412, 45);
            buttonCountingSort.Name = "buttonCountingSort";
            buttonCountingSort.Size = new Size(94, 29);
            buttonCountingSort.TabIndex = 6;
            buttonCountingSort.Text = "Counting";
            buttonCountingSort.UseVisualStyleBackColor = true;
            buttonCountingSort.Click += buttonCountingSort_Click;
            // 
            // buttonSelectionSort
            // 
            buttonSelectionSort.Location = new Point(512, 45);
            buttonSelectionSort.Name = "buttonSelectionSort";
            buttonSelectionSort.Size = new Size(94, 29);
            buttonSelectionSort.TabIndex = 7;
            buttonSelectionSort.Text = "Selection";
            buttonSelectionSort.UseVisualStyleBackColor = true;
            buttonSelectionSort.Click += buttonSelectionSort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 187);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 8;
            label1.Text = "Time:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonSelectionSort);
            Controls.Add(buttonCountingSort);
            Controls.Add(buttonInsertionSort);
            Controls.Add(buttonMergeSort);
            Controls.Add(buttonQuickSort);
            Controls.Add(listBoxResults);
            Controls.Add(textBoxInput);
            Controls.Add(buttonBubbleSort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBubbleSort;
        private TextBox textBoxInput;
        private ListBox listBoxResults;
        private Button buttonQuickSort;
        private Button buttonMergeSort;
        private Button buttonInsertionSort;
        private Button buttonCountingSort;
        private Button buttonSelectionSort;
        private Label label1;
    }
}
