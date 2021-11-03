
namespace SynopticProject___Music_Player___William_Fifield
{
    partial class VolumeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolumeControl));
            this.bunifuVSlider1 = new Bunifu.UI.WinForms.BunifuVSlider();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.SuspendLayout();
            // 
            // bunifuVSlider1
            // 
            this.bunifuVSlider1.AllowCursorChanges = true;
            this.bunifuVSlider1.AllowHomeEndKeysDetection = false;
            this.bunifuVSlider1.AllowIncrementalClickMoves = true;
            this.bunifuVSlider1.AllowMouseDownEffects = false;
            this.bunifuVSlider1.AllowMouseHoverEffects = false;
            this.bunifuVSlider1.AllowScrollingAnimations = true;
            this.bunifuVSlider1.AllowScrollKeysDetection = true;
            this.bunifuVSlider1.AllowScrollOptionsMenu = true;
            this.bunifuVSlider1.AllowShrinkingOnFocusLost = false;
            this.bunifuVSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuVSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVSlider1.BackgroundImage")));
            this.bunifuVSlider1.BindingContainer = null;
            this.bunifuVSlider1.BorderRadius = 2;
            this.bunifuVSlider1.BorderThickness = 1;
            this.bunifuVSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuVSlider1.DirectionalScroll = Utilities.BunifuSlider.BunifuVScrollBar.DirectionalMovements.BottomUp;
            this.bunifuVSlider1.DrawThickBorder = false;
            this.bunifuVSlider1.DurationBeforeShrink = 2000;
            this.bunifuVSlider1.ElapsedColor = System.Drawing.Color.CadetBlue;
            this.bunifuVSlider1.LargeChange = 10;
            this.bunifuVSlider1.Location = new System.Drawing.Point(3, 14);
            this.bunifuVSlider1.Maximum = 100;
            this.bunifuVSlider1.Minimum = 0;
            this.bunifuVSlider1.MinimumSize = new System.Drawing.Size(31, 0);
            this.bunifuVSlider1.MinimumThumbLength = 18;
            this.bunifuVSlider1.Name = "bunifuVSlider1";
            this.bunifuVSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVSlider1.OnDisableSlider.ElapsedColor = System.Drawing.Color.Silver;
            this.bunifuVSlider1.OnDisableSlider.SliderColor = System.Drawing.Color.Gainsboro;
            this.bunifuVSlider1.OnDisableSlider.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVSlider1.ScrollBarBorderColor = System.Drawing.Color.PowderBlue;
            this.bunifuVSlider1.ScrollBarColor = System.Drawing.Color.PowderBlue;
            this.bunifuVSlider1.ShrinkSizeLimit = 3;
            this.bunifuVSlider1.Size = new System.Drawing.Size(31, 148);
            this.bunifuVSlider1.SliderColor = System.Drawing.Color.PowderBlue;
            this.bunifuVSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuVSlider.SliderStyles.Thin;
            this.bunifuVSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuVScrollBar.SliderThumbStyles.Circular;
            this.bunifuVSlider1.SmallChange = 1;
            this.bunifuVSlider1.TabIndex = 0;
            this.bunifuVSlider1.ThumbColor = System.Drawing.Color.DarkCyan;
            this.bunifuVSlider1.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuVSlider1.ThumbLength = 18;
            this.bunifuVSlider1.ThumbMargin = 1;
            this.bunifuVSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuVSlider.ThumbSizes.Medium;
            this.bunifuVSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Outline;
            this.bunifuVSlider1.Value = 50;
            this.bunifuVSlider1.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs>(this.bunifuVSlider1_Scroll);
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // VolumeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.bunifuVSlider1);
            this.Name = "VolumeControl";
            this.Size = new System.Drawing.Size(38, 174);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuVSlider bunifuVSlider1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
    }
}
