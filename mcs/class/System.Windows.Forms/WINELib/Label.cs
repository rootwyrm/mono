//
// System.Windows.Forms.Label.cs
//
// Author:
//   stubbed out by Daniel Carrera (dcarrera@math.toronto.edu)
//	  implemented for Gtk+ by Rachel Hestilow (hestilow@ximian.com)
//	Dennis Hayes (dennish@raytek.com)
//   WineLib implementation started by John Sohn (jsohn@columbus.rr.com)
//
// (C) 2002 Ximian, Inc
//

namespace System.Windows.Forms {
	using System.ComponentModel;
	using System.Drawing;

	// <summary>
	//
	// </summary>
	
	public class Label : Control {

		CreateParams createParams;
		Image backgroundImage;
		BorderStyle borderStyle;
		bool autoSize;
		Image image;
		ContentAlignment imageAlign;
		ImeMode defaultImeMode;
		bool renderTransparent;
		FlatStyle flatStyle;
		int preferredHeight;
		int preferredWidth;
		bool tabStop;
		ContentAlignment textAlign;
		bool useMnemonic;

		//
		//  --- Constructor
		//
		public Label () : base ()
		{

		}
		
		//
		//  --- Public Properties
		//
		public virtual bool AutoSize {
			get {
				return autoSize;
			}
			set {
				autoSize = value;
			}
		}

		public override Image BackgroundImage {
			get {
				return backgroundImage;
			}
			set {
				backgroundImage = value;
				// FIXME: force redraw
			}
		}

		public virtual BorderStyle BorderStyle {
			get {
				return borderStyle;
			}
			set {
				borderStyle = value;
			}
		}


		public FlatStyle FlatStyle {
			get {
				return flatStyle;
			}
			set {
				flatStyle = value;
			}
		}

		public Image Image {
			get {
				return image;
			}
			set {
				image = value;
			}
		}

		public ContentAlignment ImageAlign {
			get {
				return imageAlign;
			}
			set {
				imageAlign = value;
			}
		}


		[MonoTODO]
		public int ImageIndex {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public ImageList ImageList {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		[MonoTODO]
		public new ImeMode ImeMode {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public int PreferredHeight {
			get {
				return preferredHeight;
			}
		}

		public int PreferredWidth {
			get {
				return preferredWidth;
			}
		}

		public new bool TabStop {
			get {
				return tabStop;
			}
			set {
				tabStop = value;
			}
		}

		public virtual ContentAlignment TextAlign {
			get {
				return textAlign;
			}
			set {
				textAlign = value;
			}
		}

		public bool UseMnemonic {
			get {
				return useMnemonic;
			}
			set {
				useMnemonic = value;
			}
		}

		//
		//  --- Protected Properties
		//

		protected override CreateParams CreateParams {
			get {
				return createParams;
			}
		}

		protected override Size DefaultSize {
			get {
				// FIXME: use GetSystemMetrics?
				throw new NotImplementedException ();
			}
		}

		protected virtual bool RenderTransparent {
			get {
				return renderTransparent;
			}
			set {
				renderTransparent = value;
			}
		}

		protected override ImeMode DefaultImeMode {
			get {
				return defaultImeMode;
			}
		}

		//
		//  --- Public Methods
		//
		[MonoTODO]
		public override bool Equals(object o)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode() {
			//FIXME add our proprities
			return base.GetHashCode();
		}

		public new void Select()
		{
			base.Select ();
		}

		[MonoTODO]
		public override string ToString()
		{
			throw new NotImplementedException ();
		}

		//
		//  --- Public Events
		// 
		public event EventHandler AutoSizeChanged; // {
// 			add {
// 				throw new NotImplementedException ();
// 			}
// 			remove {
// 				throw new NotImplementedException ();
// 			}
// 		}

		public event EventHandler TextAlignChanged; // {
// 			add {
// 				throw new NotImplementedException ();
// 			}
// 			remove {
// 				throw new NotImplementedException ();
// 			}
// 		}

		//
		//  --- Protected Methods
		//
		[MonoTODO]
		protected  Rectangle CalcImageRenderBounds (
			Image image, Rectangle rect, ContentAlignment align)
		{
			throw new NotImplementedException ();
		}

//  		[MonoTODO]
//  		protected  override AccessibleObject CreateAccessibilityInstance()
//  		{
//  			throw new NotImplementedException ();
//  		}

		protected override void CreateHandle () 
		{
			CreateParams createParams = new CreateParams ();
			window = new ControlNativeWindow (this);

			createParams.Caption = Text;
			createParams.ClassName = "STATIC";
			createParams.X = Top;
			createParams.Y = Left;
			createParams.Width = Width;
			createParams.Height = Height;
			createParams.ClassStyle = 0;
			createParams.ExStyle = 0;
			createParams.Param = 0;
			createParams.Parent = Parent.Handle;
			createParams.Style = (int) (
				Win32.WS_CHILD | 
				Win32.WS_VISIBLE | Win32.SS_LEFT );
			window.CreateHandle (createParams);
		}

		protected new virtual void Dispose()
		{
			//throw new NotImplementedException ();
		}

		protected  override void Dispose(bool disposing)
		{
			//throw new NotImplementedException ();
		}

		[MonoTODO]
		protected  void DrawImage (Graphics g, Image img, 
					   Rectangle r, ContentAlignment align)
		{
			throw new NotImplementedException ();
		}

		protected virtual void OnAutoSizeChanged (EventArgs e) {
			if (AutoSizeChanged != null)
				AutoSizeChanged (this, e);

		}

		protected override void OnEnabledChanged (EventArgs e)
		{
			base.OnEnabledChanged (e);
		}

		protected override void OnFontChanged (EventArgs e)
		{
			base.OnFontChanged (e);
		}

		protected override void OnPaint (PaintEventArgs e)
		{

		}

		protected override void OnParentChanged (EventArgs e)
		{
			base.OnParentChanged (e);
		}

		protected virtual void OnTextAlignChanged (EventArgs e) {
			if (TextAlignChanged != null)
				TextAlignChanged (this, e);
		}

		protected override void OnTextChanged (EventArgs e) {
			base.OnTextChanged (e);
		}

		protected override void OnVisibleChanged (EventArgs e)
		{
			base.OnVisibleChanged (e);
		}

		protected override bool ProcessMnemonic(char charCode)
		{
			return base.ProcessMnemonic (charCode);
		}

		[MonoTODO]
		protected new ContentAlignment RtlTranslateAlignment (
			ContentAlignment alignment)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		protected new HorizontalAlignment RtlTranslateAlignment (
			HorizontalAlignment alignment)
		{
			throw new NotImplementedException ();
		}
		
		[MonoTODO]
		protected new LeftRightAlignment RtlTranslateAlignment (
			LeftRightAlignment align)
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		protected new virtual void Select (bool directed, bool forward)
		{
			throw new NotImplementedException ();
		}

		protected override void SetBoundsCore (
			int x, int y, int width, int height,
			BoundsSpecified specified)
		{
			base.SetBoundsCore (x, y, width, height, specified);
		}

		protected new void UpdateBounds()
		{
			base.UpdateBounds ();
		}

		protected new void UpdateBounds (int x, int y,
					     int width, int height)
		{
			base.UpdateBounds (x, y, width, height);
		}


		protected new void UpdateBounds (int x, int y, int width,
					     int height, int clientWidth,
					     int clientHeight)
		{
			base.UpdateBounds (x, y, width, height, clientWidth, 
					   clientHeight);
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc (ref m);
		}
	}
}
