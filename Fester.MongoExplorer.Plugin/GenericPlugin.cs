using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fester.MongoExplorer.Plugin {

	public class PluginBase<T> : IGenericPlugin<T> {

		private T pluginControl;

		public T PluginControl {
			get { return pluginControl; }
			set { pluginControl = value; }
		}

		public PluginBase() {
		}

		public PluginBase(T pluginControl) {
			PluginControl = pluginControl;
		}

		public virtual void DoSomething() {

		}

		protected string pluginName = "MongoPluginBase";
		protected string pluginDescription = "MongoPluginBase";

		public string PluginName {
			get { return pluginName; }
		}

		public string PluginDescription {
			get { return pluginDescription; }
		}

	}

	public class GenericPluginControl<T> {

		public T Plugin ;

		public GenericPluginControl() {
		}

		public GenericPluginControl(T plugin) {
			Plugin = plugin;
		}

		public virtual void ControlDoSomething() {

		}

	}

	public class ImagingPluginControl : GenericPluginControl<ImagingPlugin> {

		public ImagingPluginControl() {
		}

		public ImagingPluginControl(ImagingPlugin plugin)
			: base(plugin) {

		}

		public void ControlDoSomething2() {
			MessageBox.Show("Do Something 2");
		}

		public override void ControlDoSomething() {
			MessageBox.Show("Do something 1: from base override");
		}

	}

	public class ImagingPlugin: PluginBase<ImagingPluginControl> {

		ImagingPluginControl control = new ImagingPluginControl();

		public ImagingPlugin() {
			base.PluginControl = control;
			pluginDescription = "Imaging Plugin for Mongo explorer";
			pluginName = "IMaging Plugin";
		}

		public ImagingPlugin(ImagingPluginControl control): base(control) {
		}


	}

	public interface IGenericPlugin<T> {

		string PluginName { get; }
		string PluginDescription { get; }
		T PluginControl { get; set; }
	}


	public class TestPlugin {

		public ImagingPlugin Plugin;

		public TestPlugin() {
			Plugin = new ImagingPlugin();
		}

		public void DoSomething() {
			Plugin.PluginControl.ControlDoSomething();
			Plugin.PluginControl.ControlDoSomething2();
		}

	}


}
