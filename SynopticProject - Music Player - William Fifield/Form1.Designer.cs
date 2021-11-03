
namespace SynopticProject___Music_Player___William_Fifield
{
    partial class MusicPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.playlistButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.playbackButton = new System.Windows.Forms.Button();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.selectionShape = new Bunifu.UI.WinForms.BunifuShapes();
            this.bunifuPagesSelection = new Bunifu.UI.WinForms.BunifuPages();
            this.playbackPage = new System.Windows.Forms.TabPage();
            this.muteButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.VolumeSlider = new Bunifu.UI.WinForms.BunifuVSlider();
            this.pauseButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.playbackStatusLabel = new System.Windows.Forms.Label();
            this.displayPicture = new System.Windows.Forms.PictureBox();
            this.plusButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.addToPlaylistButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.shuffleButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.volumeButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.nowPlayingLabel = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.rewindButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.forwardButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.playButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.timerSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.searchPage = new System.Windows.Forms.TabPage();
            this.MusicList = new System.Windows.Forms.ListBox();
            this.importMusicButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.playListPage = new System.Windows.Forms.TabPage();
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerInteraction = new System.Windows.Forms.Timer(this.components);
            this.userInteractionPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.bunifuPagesSelection.SuspendLayout();
            this.playbackPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayPicture)).BeginInit();
            this.searchPage.SuspendLayout();
            this.playListPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.menuPanel.Controls.Add(this.player);
            this.menuPanel.Controls.Add(this.playlistButton);
            this.menuPanel.Controls.Add(this.searchButton);
            this.menuPanel.Controls.Add(this.playbackButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuPanel.Location = new System.Drawing.Point(0, 400);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(300, 100);
            this.menuPanel.TabIndex = 0;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(37, 40);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(210, 57);
            this.player.TabIndex = 3;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // playlistButton
            // 
            this.playlistButton.BackgroundImage = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.playlist;
            this.playlistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playlistButton.FlatAppearance.BorderSize = 0;
            this.playlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistButton.Location = new System.Drawing.Point(208, 10);
            this.playlistButton.Name = "playlistButton";
            this.playlistButton.Size = new System.Drawing.Size(80, 80);
            this.playlistButton.TabIndex = 3;
            this.playlistButton.UseVisualStyleBackColor = true;
            this.playlistButton.Click += new System.EventHandler(this.playlistButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.collection;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(110, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 80);
            this.searchButton.TabIndex = 2;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // playbackButton
            // 
            this.playbackButton.BackgroundImage = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.vinyl_record;
            this.playbackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playbackButton.FlatAppearance.BorderSize = 0;
            this.playbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playbackButton.Location = new System.Drawing.Point(12, 10);
            this.playbackButton.Name = "playbackButton";
            this.playbackButton.Size = new System.Drawing.Size(80, 80);
            this.playbackButton.TabIndex = 1;
            this.playbackButton.UseVisualStyleBackColor = true;
            this.playbackButton.Click += new System.EventHandler(this.playbackButton_Click);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = true;
            // 
            // selectionShape
            // 
            this.selectionShape.Angle = 0F;
            this.selectionShape.BackColor = System.Drawing.Color.Silver;
            this.selectionShape.BorderColor = System.Drawing.Color.Silver;
            this.selectionShape.BorderThickness = 2;
            this.selectionShape.FillColor = System.Drawing.Color.Transparent;
            this.selectionShape.FillShape = true;
            this.selectionShape.Location = new System.Drawing.Point(2, 394);
            this.selectionShape.Name = "selectionShape";
            this.selectionShape.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Rectangle;
            this.selectionShape.Sides = 5;
            this.selectionShape.Size = new System.Drawing.Size(90, 10);
            this.selectionShape.TabIndex = 1;
            this.selectionShape.Text = "selectionShape";
            // 
            // bunifuPagesSelection
            // 
            this.bunifuPagesSelection.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPagesSelection.AllowTransitions = false;
            this.bunifuPagesSelection.Controls.Add(this.playbackPage);
            this.bunifuPagesSelection.Controls.Add(this.searchPage);
            this.bunifuPagesSelection.Controls.Add(this.playListPage);
            this.bunifuPagesSelection.Location = new System.Drawing.Point(12, 12);
            this.bunifuPagesSelection.Multiline = true;
            this.bunifuPagesSelection.Name = "bunifuPagesSelection";
            this.bunifuPagesSelection.Page = this.playbackPage;
            this.bunifuPagesSelection.PageIndex = 0;
            this.bunifuPagesSelection.PageName = "playbackPage";
            this.bunifuPagesSelection.PageTitle = "playbackPage";
            this.bunifuPagesSelection.SelectedIndex = 0;
            this.bunifuPagesSelection.Size = new System.Drawing.Size(276, 376);
            this.bunifuPagesSelection.TabIndex = 2;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPagesSelection.Transition = animation1;
            this.bunifuPagesSelection.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // playbackPage
            // 
            this.playbackPage.Controls.Add(this.muteButton);
            this.playbackPage.Controls.Add(this.VolumeSlider);
            this.playbackPage.Controls.Add(this.pauseButton);
            this.playbackPage.Controls.Add(this.playbackStatusLabel);
            this.playbackPage.Controls.Add(this.displayPicture);
            this.playbackPage.Controls.Add(this.plusButton);
            this.playbackPage.Controls.Add(this.addToPlaylistButton);
            this.playbackPage.Controls.Add(this.shuffleButton);
            this.playbackPage.Controls.Add(this.volumeButton);
            this.playbackPage.Controls.Add(this.nowPlayingLabel);
            this.playbackPage.Controls.Add(this.totalTime);
            this.playbackPage.Controls.Add(this.currentTime);
            this.playbackPage.Controls.Add(this.rewindButton);
            this.playbackPage.Controls.Add(this.forwardButton);
            this.playbackPage.Controls.Add(this.playButton);
            this.playbackPage.Controls.Add(this.timerSlider);
            this.playbackPage.Location = new System.Drawing.Point(4, 4);
            this.playbackPage.Name = "playbackPage";
            this.playbackPage.Padding = new System.Windows.Forms.Padding(3);
            this.playbackPage.Size = new System.Drawing.Size(268, 350);
            this.playbackPage.TabIndex = 0;
            this.playbackPage.Text = "playbackPage";
            this.playbackPage.UseVisualStyleBackColor = true;
            // 
            // muteButton
            // 
            this.muteButton.ActiveImage = null;
            this.muteButton.AllowAnimations = true;
            this.muteButton.AllowBuffering = false;
            this.muteButton.AllowToggling = false;
            this.muteButton.AllowZooming = true;
            this.muteButton.AllowZoomingOnFocus = false;
            this.muteButton.BackColor = System.Drawing.Color.Transparent;
            this.muteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.muteButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("muteButton.ErrorImage")));
            this.muteButton.FadeWhenInactive = false;
            this.muteButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.muteButton.Image = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.mute;
            this.muteButton.ImageActive = null;
            this.muteButton.ImageLocation = null;
            this.muteButton.ImageMargin = 0;
            this.muteButton.ImageSize = new System.Drawing.Size(44, 44);
            this.muteButton.ImageZoomSize = new System.Drawing.Size(45, 45);
            this.muteButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("muteButton.InitialImage")));
            this.muteButton.Location = new System.Drawing.Point(0, 327);
            this.muteButton.Name = "muteButton";
            this.muteButton.Rotation = 0;
            this.muteButton.ShowActiveImage = true;
            this.muteButton.ShowCursorChanges = false;
            this.muteButton.ShowImageBorders = true;
            this.muteButton.ShowSizeMarkers = false;
            this.muteButton.Size = new System.Drawing.Size(45, 45);
            this.muteButton.TabIndex = 16;
            this.muteButton.ToolTipText = "";
            this.muteButton.Visible = false;
            this.muteButton.WaitOnLoad = false;
            this.muteButton.Zoom = 0;
            this.muteButton.ZoomSpeed = 10;
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.AllowCursorChanges = true;
            this.VolumeSlider.AllowHomeEndKeysDetection = false;
            this.VolumeSlider.AllowIncrementalClickMoves = true;
            this.VolumeSlider.AllowMouseDownEffects = false;
            this.VolumeSlider.AllowMouseHoverEffects = false;
            this.VolumeSlider.AllowScrollingAnimations = true;
            this.VolumeSlider.AllowScrollKeysDetection = true;
            this.VolumeSlider.AllowScrollOptionsMenu = true;
            this.VolumeSlider.AllowShrinkingOnFocusLost = false;
            this.VolumeSlider.BackColor = System.Drawing.Color.AliceBlue;
            this.VolumeSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VolumeSlider.BackgroundImage")));
            this.VolumeSlider.BindingContainer = null;
            this.VolumeSlider.BorderRadius = 2;
            this.VolumeSlider.BorderThickness = 1;
            this.VolumeSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeSlider.DirectionalScroll = Utilities.BunifuSlider.BunifuVScrollBar.DirectionalMovements.BottomUp;
            this.VolumeSlider.DrawThickBorder = true;
            this.VolumeSlider.DurationBeforeShrink = 2000;
            this.VolumeSlider.ElapsedColor = System.Drawing.Color.CadetBlue;
            this.VolumeSlider.LargeChange = 10;
            this.VolumeSlider.Location = new System.Drawing.Point(10, 193);
            this.VolumeSlider.Maximum = 100;
            this.VolumeSlider.Minimum = 0;
            this.VolumeSlider.MinimumSize = new System.Drawing.Size(31, 0);
            this.VolumeSlider.MinimumThumbLength = 18;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.VolumeSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.VolumeSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.VolumeSlider.OnDisableSlider.ElapsedColor = System.Drawing.Color.Silver;
            this.VolumeSlider.OnDisableSlider.SliderColor = System.Drawing.Color.Gainsboro;
            this.VolumeSlider.OnDisableSlider.ThumbColor = System.Drawing.Color.Silver;
            this.VolumeSlider.ScrollBarBorderColor = System.Drawing.Color.PowderBlue;
            this.VolumeSlider.ScrollBarColor = System.Drawing.Color.PowderBlue;
            this.VolumeSlider.ShrinkSizeLimit = 3;
            this.VolumeSlider.Size = new System.Drawing.Size(31, 148);
            this.VolumeSlider.SliderColor = System.Drawing.Color.PowderBlue;
            this.VolumeSlider.SliderStyle = Bunifu.UI.WinForms.BunifuVSlider.SliderStyles.Thick;
            this.VolumeSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuVScrollBar.SliderThumbStyles.Circular;
            this.VolumeSlider.SmallChange = 1;
            this.VolumeSlider.TabIndex = 3;
            this.VolumeSlider.ThumbColor = System.Drawing.Color.DarkCyan;
            this.VolumeSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.VolumeSlider.ThumbLength = 18;
            this.VolumeSlider.ThumbMargin = 1;
            this.VolumeSlider.ThumbSize = Bunifu.UI.WinForms.BunifuVSlider.ThumbSizes.Large;
            this.VolumeSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Fill;
            this.VolumeSlider.Value = 50;
            this.VolumeSlider.Visible = false;
            this.VolumeSlider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs>(this.VolumeSlider_Scroll);
            // 
            // pauseButton
            // 
            this.pauseButton.ActiveImage = null;
            this.pauseButton.AllowAnimations = true;
            this.pauseButton.AllowBuffering = false;
            this.pauseButton.AllowDrop = true;
            this.pauseButton.AllowToggling = false;
            this.pauseButton.AllowZooming = true;
            this.pauseButton.AllowZoomingOnFocus = false;
            this.pauseButton.BackColor = System.Drawing.Color.Transparent;
            this.pauseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pauseButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.ErrorImage")));
            this.pauseButton.FadeWhenInactive = false;
            this.pauseButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.pauseButton.Image = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.pause_button;
            this.pauseButton.ImageActive = null;
            this.pauseButton.ImageLocation = null;
            this.pauseButton.ImageMargin = 0;
            this.pauseButton.ImageSize = new System.Drawing.Size(69, 69);
            this.pauseButton.ImageZoomSize = new System.Drawing.Size(70, 70);
            this.pauseButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.InitialImage")));
            this.pauseButton.Location = new System.Drawing.Point(98, 242);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Rotation = 0;
            this.pauseButton.ShowActiveImage = true;
            this.pauseButton.ShowCursorChanges = false;
            this.pauseButton.ShowImageBorders = true;
            this.pauseButton.ShowSizeMarkers = false;
            this.pauseButton.Size = new System.Drawing.Size(70, 70);
            this.pauseButton.TabIndex = 15;
            this.pauseButton.ToolTipText = "";
            this.pauseButton.WaitOnLoad = false;
            this.pauseButton.Zoom = 0;
            this.pauseButton.ZoomSpeed = 10;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // playbackStatusLabel
            // 
            this.playbackStatusLabel.AutoSize = true;
            this.playbackStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbackStatusLabel.Location = new System.Drawing.Point(108, 206);
            this.playbackStatusLabel.Name = "playbackStatusLabel";
            this.playbackStatusLabel.Size = new System.Drawing.Size(53, 16);
            this.playbackStatusLabel.TabIndex = 14;
            this.playbackStatusLabel.Text = "Playing";
            this.playbackStatusLabel.Visible = false;
            // 
            // displayPicture
            // 
            this.displayPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.displayPicture.Image = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.podcast;
            this.displayPicture.Location = new System.Drawing.Point(12, 6);
            this.displayPicture.Name = "displayPicture";
            this.displayPicture.Size = new System.Drawing.Size(250, 137);
            this.displayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayPicture.TabIndex = 12;
            this.displayPicture.TabStop = false;
            // 
            // plusButton
            // 
            this.plusButton.ActiveImage = null;
            this.plusButton.AllowAnimations = true;
            this.plusButton.AllowBuffering = false;
            this.plusButton.AllowDrop = true;
            this.plusButton.AllowToggling = false;
            this.plusButton.AllowZooming = true;
            this.plusButton.AllowZoomingOnFocus = false;
            this.plusButton.BackColor = System.Drawing.Color.Transparent;
            this.plusButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.plusButton.Enabled = false;
            this.plusButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("plusButton.ErrorImage")));
            this.plusButton.FadeWhenInactive = false;
            this.plusButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.plusButton.Image = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.add;
            this.plusButton.ImageActive = null;
            this.plusButton.ImageLocation = null;
            this.plusButton.ImageMargin = 0;
            this.plusButton.ImageSize = new System.Drawing.Size(22, 22);
            this.plusButton.ImageZoomSize = new System.Drawing.Size(23, 23);
            this.plusButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("plusButton.InitialImage")));
            this.plusButton.Location = new System.Drawing.Point(134, 318);
            this.plusButton.Name = "plusButton";
            this.plusButton.Rotation = 0;
            this.plusButton.ShowActiveImage = true;
            this.plusButton.ShowCursorChanges = false;
            this.plusButton.ShowImageBorders = true;
            this.plusButton.ShowSizeMarkers = false;
            this.plusButton.Size = new System.Drawing.Size(23, 23);
            this.plusButton.TabIndex = 11;
            this.plusButton.ToolTipText = "";
            this.plusButton.WaitOnLoad = false;
            this.plusButton.Zoom = 0;
            this.plusButton.ZoomSpeed = 10;
            // 
            // addToPlaylistButton
            // 
            this.addToPlaylistButton.ActiveImage = null;
            this.addToPlaylistButton.AllowAnimations = true;
            this.addToPlaylistButton.AllowBuffering = false;
            this.addToPlaylistButton.AllowDrop = true;
            this.addToPlaylistButton.AllowToggling = false;
            this.addToPlaylistButton.AllowZooming = true;
            this.addToPlaylistButton.AllowZoomingOnFocus = false;
            this.addToPlaylistButton.BackColor = System.Drawing.Color.Transparent;
            this.addToPlaylistButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addToPlaylistButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("addToPlaylistButton.ErrorImage")));
            this.addToPlaylistButton.FadeWhenInactive = false;
            this.addToPlaylistButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.addToPlaylistButton.Image = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.playlist;
            this.addToPlaylistButton.ImageActive = null;
            this.addToPlaylistButton.ImageLocation = null;
            this.addToPlaylistButton.ImageMargin = 0;
            this.addToPlaylistButton.ImageSize = new System.Drawing.Size(59, 59);
            this.addToPlaylistButton.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.addToPlaylistButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("addToPlaylistButton.InitialImage")));
            this.addToPlaylistButton.Location = new System.Drawing.Point(104, 314);
            this.addToPlaylistButton.Name = "addToPlaylistButton";
            this.addToPlaylistButton.Rotation = 0;
            this.addToPlaylistButton.ShowActiveImage = true;
            this.addToPlaylistButton.ShowCursorChanges = false;
            this.addToPlaylistButton.ShowImageBorders = true;
            this.addToPlaylistButton.ShowSizeMarkers = false;
            this.addToPlaylistButton.Size = new System.Drawing.Size(60, 60);
            this.addToPlaylistButton.TabIndex = 10;
            this.addToPlaylistButton.ToolTipText = "";
            this.addToPlaylistButton.WaitOnLoad = false;
            this.addToPlaylistButton.Zoom = 0;
            this.addToPlaylistButton.ZoomSpeed = 10;
            this.addToPlaylistButton.Click += new System.EventHandler(this.addToPlaylistButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.ActiveImage = null;
            this.shuffleButton.AllowAnimations = true;
            this.shuffleButton.AllowBuffering = false;
            this.shuffleButton.AllowToggling = false;
            this.shuffleButton.AllowZooming = true;
            this.shuffleButton.AllowZoomingOnFocus = false;
            this.shuffleButton.BackColor = System.Drawing.Color.Transparent;
            this.shuffleButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.shuffleButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("shuffleButton.ErrorImage")));
            this.shuffleButton.FadeWhenInactive = false;
            this.shuffleButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.shuffleButton.Image = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.shuffle;
            this.shuffleButton.ImageActive = null;
            this.shuffleButton.ImageLocation = null;
            this.shuffleButton.ImageMargin = 0;
            this.shuffleButton.ImageSize = new System.Drawing.Size(44, 44);
            this.shuffleButton.ImageZoomSize = new System.Drawing.Size(45, 45);
            this.shuffleButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("shuffleButton.InitialImage")));
            this.shuffleButton.Location = new System.Drawing.Point(220, 327);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Rotation = 0;
            this.shuffleButton.ShowActiveImage = true;
            this.shuffleButton.ShowCursorChanges = false;
            this.shuffleButton.ShowImageBorders = true;
            this.shuffleButton.ShowSizeMarkers = false;
            this.shuffleButton.Size = new System.Drawing.Size(45, 45);
            this.shuffleButton.TabIndex = 9;
            this.shuffleButton.ToolTipText = "";
            this.shuffleButton.WaitOnLoad = false;
            this.shuffleButton.Zoom = 0;
            this.shuffleButton.ZoomSpeed = 10;
            // 
            // volumeButton
            // 
            this.volumeButton.ActiveImage = null;
            this.volumeButton.AllowAnimations = true;
            this.volumeButton.AllowBuffering = false;
            this.volumeButton.AllowToggling = false;
            this.volumeButton.AllowZooming = true;
            this.volumeButton.AllowZoomingOnFocus = false;
            this.volumeButton.BackColor = System.Drawing.Color.Transparent;
            this.volumeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.volumeButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("volumeButton.ErrorImage")));
            this.volumeButton.FadeWhenInactive = false;
            this.volumeButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.volumeButton.Image = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.volume;
            this.volumeButton.ImageActive = null;
            this.volumeButton.ImageLocation = null;
            this.volumeButton.ImageMargin = 0;
            this.volumeButton.ImageSize = new System.Drawing.Size(44, 44);
            this.volumeButton.ImageZoomSize = new System.Drawing.Size(45, 45);
            this.volumeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("volumeButton.InitialImage")));
            this.volumeButton.Location = new System.Drawing.Point(3, 327);
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.Rotation = 0;
            this.volumeButton.ShowActiveImage = true;
            this.volumeButton.ShowCursorChanges = false;
            this.volumeButton.ShowImageBorders = true;
            this.volumeButton.ShowSizeMarkers = false;
            this.volumeButton.Size = new System.Drawing.Size(45, 45);
            this.volumeButton.TabIndex = 8;
            this.volumeButton.ToolTipText = "";
            this.volumeButton.WaitOnLoad = false;
            this.volumeButton.Zoom = 0;
            this.volumeButton.ZoomSpeed = 10;
            this.volumeButton.Click += new System.EventHandler(this.volumeButton_Click);
            // 
            // nowPlayingLabel
            // 
            this.nowPlayingLabel.AutoEllipsis = true;
            this.nowPlayingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowPlayingLabel.Location = new System.Drawing.Point(0, 214);
            this.nowPlayingLabel.Name = "nowPlayingLabel";
            this.nowPlayingLabel.Size = new System.Drawing.Size(268, 24);
            this.nowPlayingLabel.TabIndex = 6;
            this.nowPlayingLabel.Text = "Song Title";
            this.nowPlayingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Location = new System.Drawing.Point(227, 187);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(28, 13);
            this.totalTime.TabIndex = 5;
            this.totalTime.Text = "0:00";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(7, 187);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(28, 13);
            this.currentTime.TabIndex = 4;
            this.currentTime.Text = "0:00";
            // 
            // rewindButton
            // 
            this.rewindButton.ActiveImage = null;
            this.rewindButton.AllowAnimations = true;
            this.rewindButton.AllowBuffering = false;
            this.rewindButton.AllowToggling = false;
            this.rewindButton.AllowZooming = true;
            this.rewindButton.AllowZoomingOnFocus = false;
            this.rewindButton.BackColor = System.Drawing.Color.Transparent;
            this.rewindButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rewindButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("rewindButton.ErrorImage")));
            this.rewindButton.FadeWhenInactive = false;
            this.rewindButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.rewindButton.Image = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.rewind_button;
            this.rewindButton.ImageActive = null;
            this.rewindButton.ImageLocation = null;
            this.rewindButton.ImageMargin = 0;
            this.rewindButton.ImageSize = new System.Drawing.Size(54, 54);
            this.rewindButton.ImageZoomSize = new System.Drawing.Size(55, 55);
            this.rewindButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("rewindButton.InitialImage")));
            this.rewindButton.Location = new System.Drawing.Point(21, 250);
            this.rewindButton.Name = "rewindButton";
            this.rewindButton.Rotation = 0;
            this.rewindButton.ShowActiveImage = true;
            this.rewindButton.ShowCursorChanges = false;
            this.rewindButton.ShowImageBorders = true;
            this.rewindButton.ShowSizeMarkers = false;
            this.rewindButton.Size = new System.Drawing.Size(55, 55);
            this.rewindButton.TabIndex = 3;
            this.rewindButton.ToolTipText = "";
            this.rewindButton.WaitOnLoad = false;
            this.rewindButton.Zoom = 0;
            this.rewindButton.ZoomSpeed = 10;
            // 
            // forwardButton
            // 
            this.forwardButton.ActiveImage = null;
            this.forwardButton.AllowAnimations = true;
            this.forwardButton.AllowBuffering = false;
            this.forwardButton.AllowToggling = false;
            this.forwardButton.AllowZooming = true;
            this.forwardButton.AllowZoomingOnFocus = false;
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.forwardButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("forwardButton.ErrorImage")));
            this.forwardButton.FadeWhenInactive = false;
            this.forwardButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Horizontal;
            this.forwardButton.Image = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.rewind_button;
            this.forwardButton.ImageActive = null;
            this.forwardButton.ImageLocation = null;
            this.forwardButton.ImageMargin = 0;
            this.forwardButton.ImageSize = new System.Drawing.Size(54, 54);
            this.forwardButton.ImageZoomSize = new System.Drawing.Size(55, 55);
            this.forwardButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("forwardButton.InitialImage")));
            this.forwardButton.Location = new System.Drawing.Point(193, 250);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Rotation = 0;
            this.forwardButton.ShowActiveImage = true;
            this.forwardButton.ShowCursorChanges = false;
            this.forwardButton.ShowImageBorders = true;
            this.forwardButton.ShowSizeMarkers = false;
            this.forwardButton.Size = new System.Drawing.Size(55, 55);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.ToolTipText = "";
            this.forwardButton.WaitOnLoad = false;
            this.forwardButton.Zoom = 0;
            this.forwardButton.ZoomSpeed = 10;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // playButton
            // 
            this.playButton.ActiveImage = null;
            this.playButton.AllowAnimations = true;
            this.playButton.AllowBuffering = false;
            this.playButton.AllowDrop = true;
            this.playButton.AllowToggling = false;
            this.playButton.AllowZooming = true;
            this.playButton.AllowZoomingOnFocus = false;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.playButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playButton.ErrorImage")));
            this.playButton.FadeWhenInactive = false;
            this.playButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.playButton.Image = global::SynopticProject___Music_Player___William_Fifield.Properties.Resources.play_button;
            this.playButton.ImageActive = null;
            this.playButton.ImageLocation = null;
            this.playButton.ImageMargin = 0;
            this.playButton.ImageSize = new System.Drawing.Size(69, 69);
            this.playButton.ImageZoomSize = new System.Drawing.Size(70, 70);
            this.playButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("playButton.InitialImage")));
            this.playButton.Location = new System.Drawing.Point(98, 242);
            this.playButton.Name = "playButton";
            this.playButton.Rotation = 0;
            this.playButton.ShowActiveImage = true;
            this.playButton.ShowCursorChanges = false;
            this.playButton.ShowImageBorders = true;
            this.playButton.ShowSizeMarkers = false;
            this.playButton.Size = new System.Drawing.Size(70, 70);
            this.playButton.TabIndex = 1;
            this.playButton.ToolTipText = "";
            this.playButton.WaitOnLoad = false;
            this.playButton.Zoom = 0;
            this.playButton.ZoomSpeed = 10;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // timerSlider
            // 
            this.timerSlider.AllowCursorChanges = true;
            this.timerSlider.AllowHomeEndKeysDetection = false;
            this.timerSlider.AllowIncrementalClickMoves = true;
            this.timerSlider.AllowMouseDownEffects = false;
            this.timerSlider.AllowMouseHoverEffects = false;
            this.timerSlider.AllowScrollingAnimations = true;
            this.timerSlider.AllowScrollKeysDetection = true;
            this.timerSlider.AllowScrollOptionsMenu = true;
            this.timerSlider.AllowShrinkingOnFocusLost = false;
            this.timerSlider.BackColor = System.Drawing.Color.Transparent;
            this.timerSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timerSlider.BackgroundImage")));
            this.timerSlider.BindingContainer = null;
            this.timerSlider.BorderRadius = 2;
            this.timerSlider.BorderThickness = 1;
            this.timerSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timerSlider.DrawThickBorder = true;
            this.timerSlider.DurationBeforeShrink = 2000;
            this.timerSlider.ElapsedColor = System.Drawing.Color.CadetBlue;
            this.timerSlider.LargeChange = 10;
            this.timerSlider.Location = new System.Drawing.Point(48, 180);
            this.timerSlider.Maximum = 100;
            this.timerSlider.Minimum = 0;
            this.timerSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.timerSlider.MinimumThumbLength = 18;
            this.timerSlider.Name = "timerSlider";
            this.timerSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.timerSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.timerSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.timerSlider.ScrollBarBorderColor = System.Drawing.Color.PowderBlue;
            this.timerSlider.ScrollBarColor = System.Drawing.Color.PowderBlue;
            this.timerSlider.ShrinkSizeLimit = 3;
            this.timerSlider.Size = new System.Drawing.Size(174, 31);
            this.timerSlider.SliderColor = System.Drawing.Color.PowderBlue;
            this.timerSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thick;
            this.timerSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.timerSlider.SmallChange = 1;
            this.timerSlider.TabIndex = 0;
            this.timerSlider.ThumbColor = System.Drawing.Color.DarkCyan;
            this.timerSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.timerSlider.ThumbLength = 18;
            this.timerSlider.ThumbMargin = 1;
            this.timerSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.timerSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.timerSlider.Value = 0;
            // 
            // searchPage
            // 
            this.searchPage.Controls.Add(this.MusicList);
            this.searchPage.Controls.Add(this.importMusicButton);
            this.searchPage.Location = new System.Drawing.Point(4, 4);
            this.searchPage.Name = "searchPage";
            this.searchPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchPage.Size = new System.Drawing.Size(268, 350);
            this.searchPage.TabIndex = 1;
            this.searchPage.Text = "searchPage";
            this.searchPage.UseVisualStyleBackColor = true;
            // 
            // MusicList
            // 
            this.MusicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicList.FormattingEnabled = true;
            this.MusicList.ItemHeight = 24;
            this.MusicList.Location = new System.Drawing.Point(6, 6);
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(256, 292);
            this.MusicList.TabIndex = 2;
            this.MusicList.SelectedIndexChanged += new System.EventHandler(this.MusicList_SelectedIndexChanged);
            // 
            // importMusicButton
            // 
            this.importMusicButton.AllowAnimations = true;
            this.importMusicButton.AllowMouseEffects = true;
            this.importMusicButton.AllowToggling = false;
            this.importMusicButton.AnimationSpeed = 200;
            this.importMusicButton.AutoGenerateColors = false;
            this.importMusicButton.AutoRoundBorders = true;
            this.importMusicButton.AutoSizeLeftIcon = false;
            this.importMusicButton.AutoSizeRightIcon = false;
            this.importMusicButton.BackColor = System.Drawing.Color.Transparent;
            this.importMusicButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.importMusicButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importMusicButton.BackgroundImage")));
            this.importMusicButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.importMusicButton.ButtonText = "Import Music";
            this.importMusicButton.ButtonTextMarginLeft = 0;
            this.importMusicButton.ColorContrastOnClick = 45;
            this.importMusicButton.ColorContrastOnHover = 45;
            this.importMusicButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.importMusicButton.CustomizableEdges = borderEdges1;
            this.importMusicButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.importMusicButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.importMusicButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.importMusicButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.importMusicButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.importMusicButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importMusicButton.ForeColor = System.Drawing.Color.White;
            this.importMusicButton.IconLeft = null;
            this.importMusicButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importMusicButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.importMusicButton.IconLeftPadding = new System.Windows.Forms.Padding(11);
            this.importMusicButton.IconMarginLeft = 11;
            this.importMusicButton.IconPadding = 10;
            this.importMusicButton.IconRight = null;
            this.importMusicButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importMusicButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.importMusicButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.importMusicButton.IconSize = 25;
            this.importMusicButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.importMusicButton.IdleBorderRadius = 0;
            this.importMusicButton.IdleBorderThickness = 0;
            this.importMusicButton.IdleFillColor = System.Drawing.Color.Empty;
            this.importMusicButton.IdleIconLeftImage = null;
            this.importMusicButton.IdleIconRightImage = null;
            this.importMusicButton.IndicateFocus = true;
            this.importMusicButton.Location = new System.Drawing.Point(58, 324);
            this.importMusicButton.Name = "importMusicButton";
            this.importMusicButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.importMusicButton.OnDisabledState.BorderRadius = 1;
            this.importMusicButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.importMusicButton.OnDisabledState.BorderThickness = 1;
            this.importMusicButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.importMusicButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.importMusicButton.OnDisabledState.IconLeftImage = null;
            this.importMusicButton.OnDisabledState.IconRightImage = null;
            this.importMusicButton.onHoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.importMusicButton.onHoverState.BorderRadius = 1;
            this.importMusicButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.importMusicButton.onHoverState.BorderThickness = 1;
            this.importMusicButton.onHoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.importMusicButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.importMusicButton.onHoverState.IconLeftImage = null;
            this.importMusicButton.onHoverState.IconRightImage = null;
            this.importMusicButton.OnIdleState.BorderColor = System.Drawing.Color.SkyBlue;
            this.importMusicButton.OnIdleState.BorderRadius = 1;
            this.importMusicButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.importMusicButton.OnIdleState.BorderThickness = 1;
            this.importMusicButton.OnIdleState.FillColor = System.Drawing.Color.SkyBlue;
            this.importMusicButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.importMusicButton.OnIdleState.IconLeftImage = null;
            this.importMusicButton.OnIdleState.IconRightImage = null;
            this.importMusicButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.importMusicButton.OnPressedState.BorderRadius = 1;
            this.importMusicButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.importMusicButton.OnPressedState.BorderThickness = 1;
            this.importMusicButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.importMusicButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.importMusicButton.OnPressedState.IconLeftImage = null;
            this.importMusicButton.OnPressedState.IconRightImage = null;
            this.importMusicButton.Size = new System.Drawing.Size(150, 39);
            this.importMusicButton.TabIndex = 1;
            this.importMusicButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.importMusicButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.importMusicButton.TextMarginLeft = 0;
            this.importMusicButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.importMusicButton.UseDefaultRadiusAndThickness = true;
            this.importMusicButton.Click += new System.EventHandler(this.importMusicButton_Click);
            // 
            // playListPage
            // 
            this.playListPage.Controls.Add(this.playlistBox);
            this.playListPage.Location = new System.Drawing.Point(4, 4);
            this.playListPage.Name = "playListPage";
            this.playListPage.Size = new System.Drawing.Size(268, 350);
            this.playListPage.TabIndex = 2;
            this.playListPage.Text = "playlistPage";
            this.playListPage.UseVisualStyleBackColor = true;
            // 
            // playlistBox
            // 
            this.playlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.ItemHeight = 24;
            this.playlistBox.Location = new System.Drawing.Point(3, 42);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(262, 244);
            this.playlistBox.TabIndex = 0;
            this.playlistBox.SelectedIndexChanged += new System.EventHandler(this.playlistBox_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "\"MP3 files | *.mp3; | MP3s | *.mp3 \"";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerInteraction
            // 
            this.timerInteraction.Interval = 1000;
            this.timerInteraction.Tick += new System.EventHandler(this.timerInteraction_Tick);
            // 
            // userInteractionPanel
            // 
            this.userInteractionPanel.BackColor = System.Drawing.Color.DarkGray;
            this.userInteractionPanel.Location = new System.Drawing.Point(2, 3);
            this.userInteractionPanel.Name = "userInteractionPanel";
            this.userInteractionPanel.Size = new System.Drawing.Size(295, 249);
            this.userInteractionPanel.TabIndex = 16;
            this.userInteractionPanel.Visible = false;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.userInteractionPanel);
            this.Controls.Add(this.bunifuPagesSelection);
            this.Controls.Add(this.selectionShape);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            this.Click += new System.EventHandler(this.MusicPlayer_Click);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.bunifuPagesSelection.ResumeLayout(false);
            this.playbackPage.ResumeLayout(false);
            this.playbackPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayPicture)).EndInit();
            this.searchPage.ResumeLayout(false);
            this.playListPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Button playlistButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button playbackButton;
        private Bunifu.UI.WinForms.BunifuPages bunifuPagesSelection;
        private System.Windows.Forms.TabPage playbackPage;
        private System.Windows.Forms.TabPage searchPage;
        private System.Windows.Forms.TabPage playListPage;
        private Bunifu.UI.WinForms.BunifuShapes selectionShape;
        private Bunifu.UI.WinForms.BunifuHSlider timerSlider;
        private Bunifu.UI.WinForms.BunifuImageButton playButton;
        private Bunifu.UI.WinForms.BunifuImageButton rewindButton;
        private Bunifu.UI.WinForms.BunifuImageButton forwardButton;
        private System.Windows.Forms.Label nowPlayingLabel;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label currentTime;
        private Bunifu.UI.WinForms.BunifuImageButton shuffleButton;
        private Bunifu.UI.WinForms.BunifuImageButton volumeButton;
        private Bunifu.UI.WinForms.BunifuImageButton addToPlaylistButton;
        private Bunifu.UI.WinForms.BunifuImageButton plusButton;
        private System.Windows.Forms.PictureBox displayPicture;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton importMusicButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox MusicList;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Label playbackStatusLabel;
        private Bunifu.UI.WinForms.BunifuImageButton pauseButton;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuVSlider VolumeSlider;
        private System.Windows.Forms.ListBox playlistBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timerInteraction;
        private System.Windows.Forms.Panel userInteractionPanel;
        private Bunifu.UI.WinForms.BunifuImageButton muteButton;
    }
}

