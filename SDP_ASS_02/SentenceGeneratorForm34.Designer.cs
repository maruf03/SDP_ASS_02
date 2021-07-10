
namespace SDP_ASS_02
{
    partial class SentenceGeneratorForm34
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
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.TextBox();
            this.VocabularyList = new System.Windows.Forms.ListView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.StrategyList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(184, 179);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 0;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(12, 13);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(100, 23);
            this.word.TabIndex = 3;
            this.word.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VocabularyList
            // 
            this.VocabularyList.HideSelection = false;
            this.VocabularyList.Location = new System.Drawing.Point(12, 42);
            this.VocabularyList.Name = "VocabularyList";
            this.VocabularyList.Size = new System.Drawing.Size(247, 131);
            this.VocabularyList.TabIndex = 4;
            this.VocabularyList.UseCompatibleStateImageBehavior = false;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(184, 13);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // StrategyList
            // 
            this.StrategyList.FormattingEnabled = true;
            this.StrategyList.Items.AddRange(new object[] {
            "Random Sentence Generator",
            "Sorted Sentence Generator",
            "Ordered Sentence Generator"});
            this.StrategyList.Location = new System.Drawing.Point(12, 179);
            this.StrategyList.Name = "StrategyList";
            this.StrategyList.Size = new System.Drawing.Size(166, 23);
            this.StrategyList.TabIndex = 7;
            this.StrategyList.SelectedIndexChanged += new System.EventHandler(this.StrategyList_SelectedIndexChanged);
            // 
            // SentenceGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 217);
            this.Controls.Add(this.StrategyList);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.VocabularyList);
            this.Controls.Add(this.word);
            this.Controls.Add(this.GenerateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SentenceGeneratorForm";
            this.Text = "Sentence Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.ListView VocabularyList;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox StrategyList;
    }
}

