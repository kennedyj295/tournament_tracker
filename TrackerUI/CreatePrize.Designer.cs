namespace TrackerUI
{
    partial class CreatePrize
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
            this.CreatePrizeHeader = new System.Windows.Forms.Label();
            this.PlaceNumberValue = new System.Windows.Forms.TextBox();
            this.PlaceNumber = new System.Windows.Forms.Label();
            this.PrizePercentValue = new System.Windows.Forms.TextBox();
            this.PrizePercent = new System.Windows.Forms.Label();
            this.PrizeAmountValue = new System.Windows.Forms.TextBox();
            this.PrizeAmount = new System.Windows.Forms.Label();
            this.PlaceNameValue = new System.Windows.Forms.TextBox();
            this.PlaceName = new System.Windows.Forms.Label();
            this.Option = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePrizeHeader
            // 
            this.CreatePrizeHeader.AutoSize = true;
            this.CreatePrizeHeader.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeHeader.Location = new System.Drawing.Point(23, 29);
            this.CreatePrizeHeader.Name = "CreatePrizeHeader";
            this.CreatePrizeHeader.Size = new System.Drawing.Size(217, 50);
            this.CreatePrizeHeader.TabIndex = 15;
            this.CreatePrizeHeader.Text = "Create Prize";
            // 
            // PlaceNumberValue
            // 
            this.PlaceNumberValue.Location = new System.Drawing.Point(299, 113);
            this.PlaceNumberValue.Name = "PlaceNumberValue";
            this.PlaceNumberValue.Size = new System.Drawing.Size(256, 47);
            this.PlaceNumberValue.TabIndex = 17;
            // 
            // PlaceNumber
            // 
            this.PlaceNumber.AutoSize = true;
            this.PlaceNumber.Location = new System.Drawing.Point(55, 119);
            this.PlaceNumber.Name = "PlaceNumber";
            this.PlaceNumber.Size = new System.Drawing.Size(204, 41);
            this.PlaceNumber.TabIndex = 16;
            this.PlaceNumber.Text = "Place Number";
            // 
            // PrizePercentValue
            // 
            this.PrizePercentValue.Location = new System.Drawing.Point(299, 352);
            this.PrizePercentValue.Name = "PrizePercentValue";
            this.PrizePercentValue.PlaceholderText = "0";
            this.PrizePercentValue.Size = new System.Drawing.Size(256, 47);
            this.PrizePercentValue.TabIndex = 19;
            this.PrizePercentValue.Text = "0";
            // 
            // PrizePercent
            // 
            this.PrizePercent.AutoSize = true;
            this.PrizePercent.Location = new System.Drawing.Point(55, 352);
            this.PrizePercent.Name = "PrizePercent";
            this.PrizePercent.Size = new System.Drawing.Size(238, 41);
            this.PrizePercent.TabIndex = 18;
            this.PrizePercent.Text = "Prize Percentage";
            // 
            // PrizeAmountValue
            // 
            this.PrizeAmountValue.Location = new System.Drawing.Point(299, 219);
            this.PrizeAmountValue.Name = "PrizeAmountValue";
            this.PrizeAmountValue.PlaceholderText = "0";
            this.PrizeAmountValue.Size = new System.Drawing.Size(256, 47);
            this.PrizeAmountValue.TabIndex = 21;
            this.PrizeAmountValue.Text = "0";
            // 
            // PrizeAmount
            // 
            this.PrizeAmount.AutoSize = true;
            this.PrizeAmount.Location = new System.Drawing.Point(55, 225);
            this.PrizeAmount.Name = "PrizeAmount";
            this.PrizeAmount.Size = new System.Drawing.Size(197, 41);
            this.PrizeAmount.TabIndex = 20;
            this.PrizeAmount.Text = "Prize Amount";
            // 
            // PlaceNameValue
            // 
            this.PlaceNameValue.Location = new System.Drawing.Point(299, 166);
            this.PlaceNameValue.Name = "PlaceNameValue";
            this.PlaceNameValue.Size = new System.Drawing.Size(256, 47);
            this.PlaceNameValue.TabIndex = 23;
            // 
            // PlaceName
            // 
            this.PlaceName.AutoSize = true;
            this.PlaceName.Location = new System.Drawing.Point(55, 175);
            this.PlaceName.Name = "PlaceName";
            this.PlaceName.Size = new System.Drawing.Size(174, 41);
            this.PlaceName.TabIndex = 22;
            this.PlaceName.Text = "Place Name";
            // 
            // Option
            // 
            this.Option.AutoSize = true;
            this.Option.Location = new System.Drawing.Point(263, 290);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(51, 41);
            this.Option.TabIndex = 24;
            this.Option.Text = "Or";
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.Location = new System.Drawing.Point(220, 466);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(173, 100);
            this.CreatePrizeButton.TabIndex = 29;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 658);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.PlaceNameValue);
            this.Controls.Add(this.PlaceName);
            this.Controls.Add(this.PrizeAmountValue);
            this.Controls.Add(this.PrizeAmount);
            this.Controls.Add(this.PrizePercentValue);
            this.Controls.Add(this.PrizePercent);
            this.Controls.Add(this.PlaceNumberValue);
            this.Controls.Add(this.PlaceNumber);
            this.Controls.Add(this.CreatePrizeHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreatePrize";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CreatePrizeHeader;
        private TextBox PlaceNumberValue;
        private Label PlaceNumber;
        private TextBox PrizePercentValue;
        private Label PrizePercent;
        private TextBox PrizeAmountValue;
        private Label PrizeAmount;
        private TextBox PlaceNameValue;
        private Label PlaceName;
        private Label Option;
        private Button CreatePrizeButton;
    }
}