// IOSecurity.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using System.Security;
using System.Security.Permissions;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
		private void Assert(params string[] paths) {
			new FileIOPermission(FileIOPermissionAccess.AllAccess, paths).Assert();
		}

		private bool CheckFile(string path) {
			new FileIOPermission(PermissionState.Unrestricted).Assert();
			try {
				path = Path.GetFullPath(path);
				string allowed = Path.GetFullPath(Environment.CurrentDirectory);
				return path.StartsWith(allowed);
			} finally {
				CodeAccessPermission.RevertAssert();
			}
		}

		private bool BeforeOperation(string path) {
			if ( CheckFile(path) ) {
				Assert(path);
				return true;
			}
			return false;
		}

		private bool BeforeOperation(string path1, string path2) {
			if ( CheckFile(path1) && CheckFile(path2) ) {
				Assert(path1, path2);
				return true;
			}
			return false;
		}

		private bool BeforeOperation(string path1, string path2, string path3) {
			if ( CheckFile(path1) && CheckFile(path2) && CheckFile(path3) ) {
				Assert(path1, path2, path3);
				return true;
			}
			return false;
		}

		private void AfterOperation() {
			CodeAccessPermission.RevertAssert();
		}
	}
}

