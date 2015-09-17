using Fester.MongoExplorer.Common;
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
				foreach (Control child in next.Controls) {
					// exclude fixed styled controls
					if ( !((child.Tag is string) && (string)child.Tag == "fixed")) {
						stack.Push(child);
					}
				}
				yield return next;
			}
		}

		public static void ApplyStyle(string name, Control rootControl, bool includePanels) {
			ApplicationTheme theme = StandardThemes.FirstOrDefault(t => t.ThemeName == name);
			ApplyStyle(theme, rootControl, includePanels);
		}

		public static void ApplyStyle(ApplicationTheme theme, Control root, bool includePanels) {
			root.BackColor = theme.BaseColor;
			if (includePanels) {
				SetPanelStyling(root, theme.PanelFill);
			}
			SetFlatTabPageStyling(root, theme.BaseColor);
			SetTabPageStyling(root, theme.TabFill);
			SetDataGridStyling(root, theme.TabFill, theme.InputFill);
			SetButtonStyling(root, theme.ButtonFill, theme.ButtonBorder);
			SetListBoxStyling(root, theme.InputFill);
			SetTextBoxStyling(root, theme.InputFill);
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

		private static void SetDataGridStyling(Control root, Color backColor, Color cellColor) {
			foreach (var grid in Tools.GetAllChildren(root).OfType<DataGridView>()) {
				grid.EnableHeadersVisualStyles = false;
				grid.BackColor = backColor;
				grid.DefaultCellStyle.BackColor = cellColor;
				grid.DefaultCellStyle.SelectionBackColor = ColorUtils.ChangeBrightness(cellColor, 0.6);
				grid.ColumnHeadersDefaultCellStyle.BackColor = ColorUtils.ChangeBrightness(cellColor, 0.8);
				grid.RowHeadersDefaultCellStyle.BackColor = ColorUtils.ChangeBrightness(cellColor, 0.8);
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

		static Tools() {
			CreateThemes();
		}


		public static List<ApplicationTheme> StandardThemes = new List<ApplicationTheme>();

		public static void CreateThemes() {

			ApplicationTheme theme;
				
			theme	= new ApplicationTheme() {
				BaseColor = Color.White,
				ButtonBorder = Color.Gray,
				ButtonFill = Color.LightGray,
				InputBorder = Color.LightGray,
				InputFill = ColorUtils.ChangeBrightness(Color.White, 0.95),
				TabFill = ColorUtils.ChangeBrightness(Color.White, 0.85),
				PanelFill = ColorUtils.ChangeBrightness(Color.White, 0.85),
				ThemeName = "WhiteOut"
			};
			StandardThemes.Add(theme);

			theme = new ApplicationTheme() {
				BaseColor = Color.Gray,
				ButtonBorder = Color.Gray,
				ButtonFill = Color.LightSalmon,
				InputBorder = Color.DarkRed,
				InputFill = Color.LightGray,
				TabFill = Color.DarkGray,
				ThemeName = "GrayDays"
			};
			StandardThemes.Add(theme);
		}

	}

}
