// IOModule.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	/// <summary>
	/// The default module implementation for input/output.
	/// </summary>
	public partial class IOModule : AbstractLatipiumModule {
		/// <summary>
		/// Translates the specified path.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="type">The type requesting the file.</param>
		[LatipiumMethod("FindFile")]
		public string Translate(string path, Type type) {
			return Translate(path, type.Assembly);
		}

		/// <summary>
		/// Translates the specified path.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="assembly">The assembly requesting the file.</param>
		[LatipiumMethod("FindFile")]
		public string Translate(string path, Assembly assembly) {
			AssemblyName assemblyName = assembly.GetName();
			string name = assemblyName.Name;
			string globalVersion = Translate(path, name);
			new FileIOPermission(PermissionState.Unrestricted).Assert();
			if ( File.Exists(globalVersion) ) {
				CodeAccessPermission.RevertAssert();
				return globalVersion;
			} else {
				string version = assemblyName.Version.ToString();
				string localVersion = Translate(path, name, version);
				if ( File.Exists(localVersion) ) {
					CodeAccessPermission.RevertAssert();
					return localVersion;
				} else {
					CodeAccessPermission.RevertAssert();
					return globalVersion;
				}
			}
		}

		/// <summary>
		/// Translates the specified path.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="assembly">The assembly requesting the file.</param>
		[LatipiumMethod("FindFile")]
		public string Translate(string path, string assembly) {
			return Path.GetFullPath(Path.Combine(Path.Combine("data", assembly), path));
		}

		/// <summary>
		/// Translates the specified path.
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="assembly">The assembly requesting the file.</param>
		/// <param name="version">The version of the assembly</param>
		[LatipiumMethod("FindFile")]
		public string Translate(string path, string assembly, string version) {
#if DEBUG
			return Path.GetFullPath(path);
#else
			return Path.GetFullPath(Path.Combine(string.Concat(assembly, ".", version), path));
#endif
		}

		/// <summary>
		/// Gets the modules that should be loaded.
		/// </summary>
		/// <returns>The paths to the modules.</returns>
		[LatipiumMethod("GetModules")]
		public IEnumerable<string> GetModules() {
			new FileIOPermission(PermissionState.Unrestricted).Assert();
			IEnumerable<string> ret = Directory.GetFiles(Environment.CurrentDirectory, "*.dll")
				.Where((string name) => !(
					name.EndsWith("Com.Latipium.Core.dll") ||
					name.EndsWith("Com.Latipium.Defaults.IO.dll") ||
					name.EndsWith("Com.Latipium.Security.dll") ||
					name.EndsWith("log4net.dll")));
			CodeAccessPermission.RevertAssert();
			return ret;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Com.Latipium.Defaults.IO.IOModule"/> class.
		/// </summary>
		public IOModule() : base(new string[] { "Com.Latipium.Modules.IO" }) {
		}
	}
}

