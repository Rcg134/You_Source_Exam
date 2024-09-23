namespace String_Sorting
{
    partial class MainFormView
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
            Btn_ExecuteSort = new Button();
            Cmb_SortList = new ComboBox();
            Txt_Input = new TextBox();
            Lbl_SortedString = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Btn_ExecuteSort
            // 
            Btn_ExecuteSort.Anchor = AnchorStyles.None;
            Btn_ExecuteSort.Location = new Point(104, 175);
            Btn_ExecuteSort.Name = "Btn_ExecuteSort";
            Btn_ExecuteSort.Size = new Size(96, 38);
            Btn_ExecuteSort.TabIndex = 0;
            Btn_ExecuteSort.Text = "Sort";
            Btn_ExecuteSort.UseVisualStyleBackColor = true;
            Btn_ExecuteSort.Click += Btn_ExecuteSort_Click;
            // 
            // Cmb_SortList
            // 
            Cmb_SortList.Anchor = AnchorStyles.None;
            Cmb_SortList.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_SortList.FormattingEnabled = true;
            Cmb_SortList.Location = new Point(30, 133);
            Cmb_SortList.Name = "Cmb_SortList";
            Cmb_SortList.Size = new Size(252, 23);
            Cmb_SortList.TabIndex = 1;
            Cmb_SortList.SelectedIndexChanged += Cmb_SortList_SelectedIndexChanged;
            // 
            // Txt_Input
            // 
            Txt_Input.Anchor = AnchorStyles.None;
            Txt_Input.Location = new Point(30, 71);
            Txt_Input.Name = "Txt_Input";
            Txt_Input.Size = new Size(252, 23);
            Txt_Input.TabIndex = 2;
            Txt_Input.WordWrap = false;
            // 
            // Lbl_SortedString
            // 
            Lbl_SortedString.Anchor = AnchorStyles.None;
            Lbl_SortedString.AutoEllipsis = true;
            Lbl_SortedString.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_SortedString.Location = new Point(30, 226);
            Lbl_SortedString.Name = "Lbl_SortedString";
            Lbl_SortedString.Size = new Size(252, 40);
            Lbl_SortedString.TabIndex = 3;
            Lbl_SortedString.Text = "Input Something";
            Lbl_SortedString.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_SortedString.UseWaitCursor = true;
            Lbl_SortedString.Click += Lbl_SortedString_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(30, 53);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "User Input";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(30, 115);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 5;
            label2.Text = "Sort Strategy";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // MainFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 301);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Lbl_SortedString);
            Controls.Add(Txt_Input);
            Controls.Add(Cmb_SortList);
            Controls.Add(Btn_ExecuteSort);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "MainFormView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sorting";
            Load += MainViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_ExecuteSort;
        private ComboBox Cmb_SortList;
        private TextBox Txt_Input;
        private Label Lbl_SortedString;
        private Label label1;
        private Label label2;
    }
}
