using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fester.MongoExplorer.App {
	public static class Tools {

		public static IEnumerable<Control> GetAllChildren(this Control root) {
			var stack = new Stack<Control>();
			stack.Push(root);
			while (stack.Any()) {
				var next = stack.Pop();
				foreach (Control child in next.Controls)
					stack.Push(child);
				yield return next;
			}
		}


		public static void ApplyStyle(Control root, Color baseColor, Color tabFill, Color buttonFill, Color buttonBorder, Color inputFill) {
			root.BackColor = baseColor;
			SetFlatTabPageStyling(root, baseColor);
			SetTabPageStyling(root, tabFill);
			//SetPanelStyling(root, tabFill);
			SetButtonStyling(root, buttonFill, buttonBorder);
			SetListBoxStyling(root, inputFill);
			SetTextBoxStyling(root, inputFill);
		}

		private static void SetFlatTabPageStyling(Control root, Color backColor) {
			foreach (var button in Tools.GetAllChildren(root).OfType<FlatTabControl.FlatTabControl>()) {
				button.myBackColor = backColor;
			}
		}

		private static void SetTabPageStyling(Control root, Color backColor) {
			foreach (var button in Tools.GetAllChildren(root).OfType<TabPage>()) {
				button.BackColor = backColor;
			}
		}

		public static void SetPanelStyling(Control root, Color backColor) {
			foreach (var button in Tools.GetAllChildren(root).OfType<Panel>()) {
				button.BackColor = backColor;
			}
		}

		private static void SetButtonStyling(Control root, Color buttonFill, Color buttonBorder) {
			foreach (var button in Tools.GetAllChildren(root).OfType<Button>()) {
				button.BackColor = buttonFill;
				button.FlatStyle = FlatStyle.Flat;
				button.FlatAppearance.BorderColor = buttonBorder;
			}
		}

		private static void SetListBoxStyling(Control root, Color backColor) {
			foreach (var listBox in Tools.GetAllChildren(root).OfType<ListBox>()) {
				listBox.BackColor = backColor;
				listBox.BorderStyle = BorderStyle.None;
			}
		}

		private static void SetTextBoxStyling(Control root, Color backColor) {
			foreach (var textBox in Tools.GetAllChildren(root).OfType<TextBox>()) {
				textBox.BackColor = backColor;
				textBox.BorderStyle = BorderStyle.FixedSingle;
			}
			foreach (var textBox in Tools.GetAllChildren(root).OfType<RichTextBox>()) {
				textBox.BackColor = backColor;
				textBox.BorderStyle = BorderStyle.FixedSingle;
			}
		}

	}
}
