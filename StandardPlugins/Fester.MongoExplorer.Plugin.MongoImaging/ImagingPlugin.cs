using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Builders;
using MongoDB.Driver;
using Fester.MongoExplorer.Common;
using Fester.MongoExplorer.Plugin;
using System.ComponentModel.Composition;
using IMAGING = Blithe.Common.Imaging;
using Fester.MongoExplorer.Plugin.MongoImaging.Collections;
using Fester.MongoExplorer.Plugin.MongoImaging.Repository;

namespace Fester.MongoExplorer.Plugin.MongoImaging {

	[Export(typeof(IMongoPlugin)), ExportMetadata("Name", "Imaging Plugin")]
	public class MongoImagingPlugin: MongoPluginBase {

		#region Constructors

		/// <summary>
		/// Need this default constructor for MEF plugin instantiation
		/// </summary>
		[System.ComponentModel.Composition.ImportingConstructor]
		public MongoImagingPlugin() {
			SetIdentity();
		}

		public MongoImagingPlugin(MongoExplorerSession explorer)
			: base(explorer) {
			this.explorer = explorer;
			repository.Session = explorer;
			SetIdentity();
		}

		private ImageDocRepository repository = new ImageDocRepository();

		#endregion

		#region Plugin stuff

		private void SetIdentity() {
			this.pluginName = "Imaging Plugin";
			this.pluginDescription = "Imaging module plugin";
		}

		protected override void SetPluginControl() {
			base.pluginControl = new ImagingPluginControl();
			base.SetPluginControl();
		}


		#endregion

		#region Imaging Stuff

		/// <summary>
		/// Get all images from the database
		/// </summary>
		/// <returns></returns>
		public List<ImageDoc> GetImages() {
			ImageDocActions imageActions = new ImageDocActions(this.explorer);
			List<ImageDoc> images = imageActions.GetList();
			return images;
		}

		/// <summary>
		/// Save an image document
		/// </summary>
		/// <returns></returns>
		public void Save(ImageDoc doc) {
			ImageDocActions imageActions = new ImageDocActions(this.explorer);
			ReplaceOneResult result = imageActions.Save(doc);
		}




		#endregion

	}
}
