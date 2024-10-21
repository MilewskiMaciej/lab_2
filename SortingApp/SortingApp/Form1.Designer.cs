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
            textBoxInput = new TextBox();
            listBoxResults = new ListBox();
            buttonSelectionSort = new Button();
            buttonBubbleSort = new Button();
            buttonCountingSort = new Button();
            buttonInsertionSort = new Button();
            buttonMergeSort = new Button();
            buttonQuickSort = new Button();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(20, 45);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(35, 27);
            textBoxInput.TabIndex = 0;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 20;
            listBoxResults.Location = new Point(20, 87);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(150, 104);
            listBoxResults.TabIndex = 1;
            // 
            // buttonSelectionSort
            // 
            buttonSelectionSort.Location = new Point(20, 210);
            buttonSelectionSort.Name = "buttonSelectionSort";
            buttonSelectionSort.Size = new Size(94, 29);
            buttonSelectionSort.TabIndex = 2;
            buttonSelectionSort.Text = "SELECTION";
            buttonSelectionSort.UseVisualStyleBackColor = true;
            // 
            // buttonBubbleSort
            // 
            buttonBubbleSort.Location = new Point(21, 392);
            buttonBubbleSort.Name = "buttonBubbleSort";
            buttonBubbleSort.Size = new Size(93, 28);
            buttonBubbleSort.TabIndex = 3;
            buttonBubbleSort.Text = "BUBBLE";
            buttonBubbleSort.UseVisualStyleBackColor = true;
            // 
            // buttonCountingSort
            // 
            buttonCountingSort.Location = new Point(20, 245);
            buttonCountingSort.Name = "buttonCountingSort";
            buttonCountingSort.Size = new Size(94, 29);
            buttonCountingSort.TabIndex = 4;
            buttonCountingSort.Text = "COUNTING";
            buttonCountingSort.UseVisualStyleBackColor = true;
            // 
            // buttonInsertionSort
            // 
            buttonInsertionSort.Location = new Point(20, 280);
            buttonInsertionSort.Name = "buttonInsertionSort";
            buttonInsertionSort.Size = new Size(94, 29);
            buttonInsertionSort.TabIndex = 5;
            buttonInsertionSort.Text = "INSERTION";
            buttonInsertionSort.UseVisualStyleBackColor = true;
            // 
            // buttonMergeSort
            // 
            buttonMergeSort.Location = new Point(20, 322);
            buttonMergeSort.Name = "buttonMergeSort";
            buttonMergeSort.Size = new Size(94, 29);
            buttonMergeSort.TabIndex = 6;
            buttonMergeSort.Text = "MERGE";
            buttonMergeSort.UseVisualStyleBackColor = true;
            // 
            // buttonQuickSort
            // 
            buttonQuickSort.Location = new Point(20, 357);
            buttonQuickSort.Name = "buttonQuickSort";
            buttonQuickSort.Size = new Size(94, 29);
            buttonQuickSort.TabIndex = 7;
            buttonQuickSort.Text = "QUICK";
            buttonQuickSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonQuickSort);
            Controls.Add(buttonMergeSort);
            Controls.Add(buttonInsertionSort);
            Controls.Add(buttonCountingSort);
            Controls.Add(buttonBubbleSort);
            Controls.Add(buttonSelectionSort);
            Controls.Add(listBoxResults);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private ListBox listBoxResults;
        private Button buttonSelectionSort;
        private Button buttonBubbleSort;
        private Button buttonCountingSort;
        private Button buttonInsertionSort;
        private Button buttonMergeSort;
        private Button buttonQuickSort;
    }
}
