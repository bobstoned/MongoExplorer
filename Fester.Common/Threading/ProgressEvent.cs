using System;
using System.Collections.Generic;
using System.Text;

namespace Fester.Common {


	/// <summary>
	/// Delegate used to issue print progress notifications
	/// for the bulk print process
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public delegate void ProgressEventHandler(object sender, ProgressEventArgs e);

	/// <summary>
	/// Event args for the BulkPrintProgressEvent delegate
	/// </summary>
	public class ProgressEventArgs : EventArgs {

		#region Private Declarations

		private Object progressItem = null;
		private int progressPosition;
		private ProgressEvents progressEvent;
		private bool cancelled = false;
		private string message = string.Empty;
		private Exception exception = null;

		#endregion

		#region Public Properties

		public bool Cancelled {
			get { return cancelled; }
			set { cancelled = value; }
		}
		public Object ProgressItem {
			get { return progressItem; }
			set { progressItem = value; }
		}

		public int ProgressPosition {
			get { return progressPosition; }
			set { progressPosition = value; }
		}

		public ProgressEvents ProgressEvent {
			get { return progressEvent; }
			set { progressEvent = value; }
		}

		public string Message {
			get { return message; }
			set { message = value; }
		}

		public Exception Exception {
			get { return exception; }
			set { exception = value; }
		}

		#endregion

		#region Public Constructors

		// ProgressEventArgs constructor
		public ProgressEventArgs(Object progressItem, int progressPosition, ProgressEvents progressEvent) {
			this.ProgressItem = progressItem;
			this.ProgressPosition = progressPosition;
			this.ProgressEvent = progressEvent;
		}

		// ProgressEventArgs constructor
		public ProgressEventArgs(Object progressItem, int progressPosition, ProgressEvents progressEvent, Exception exception) {
			this.ProgressItem = progressItem;
			this.ProgressPosition = progressPosition;
			this.ProgressEvent = progressEvent;
			this.Exception = exception;
		}

		#endregion

	}

	/// <summary>
	/// Type of event
	/// </summary>
	public enum ProgressEvents {
		Cancelled,
		Completed,
		ErrorOccurred,
		ProcessedItem,
		Started
	}

}
