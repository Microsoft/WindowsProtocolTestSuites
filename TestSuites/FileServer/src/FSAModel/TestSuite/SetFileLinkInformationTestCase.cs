// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.FileSharing.FSA.TestSuite {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.Protocols.TestTools;
    
    
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SetFileLinkInformationTestCase : PtfTestClassBase {
        
        public SetFileLinkInformationTestCase() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }
        
        #region Adapter Instances
        private Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.IFSAAdapter IFSAAdapterInstance;
        #endregion
        
        #region Class Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context) {
            PtfTestClassBase.Initialize(context);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void ClassCleanup() {
            PtfTestClassBase.Cleanup();
        }
        #endregion
        
        #region Test Initialization and Cleanup
        protected override void TestInitialize() {
            this.InitializeTestManager();
            this.IFSAAdapterInstance = ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.IFSAAdapter)(this.GetAdapter(typeof(Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.IFSAAdapter))));
        }
        
        protected override void TestCleanup() {
            base.TestCleanup();
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Model)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Fsa)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.SetFileInformation)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.NonSmb)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Positive)]
        public void SetFileLinkInformationTestCaseS0() {
            this.Manager.BeginTest("SetFileLinkInformationTestCaseS0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call FsaInitial()\'");
            this.IFSAAdapterInstance.FsaInitial();
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return FsaInitial\'");
            this.Manager.Comment("reaching state \'S8\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp0;
            this.Manager.Comment("executing step \'call CreateFile(NORMAL,NON_DIRECTORY_FILE,NULL,GENERIC_WRITE,FILE" +
                    "_SHARE_WRITE,OPEN_IF,StreamIsFound,IsNotSymbolicLink,DataFile,PathNameValid)\'");
            temp0 = this.IFSAAdapterInstance.CreateFile(Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAttribute.NORMAL, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateOptions.NON_DIRECTORY_FILE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamTypeNameToOpen.NULL, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAccess.GENERIC_WRITE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.ShareAccess.FILE_SHARE_WRITE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateDisposition.OPEN_IF, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamFoundType)(0)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.SymbolicLinkType)(1)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileType)(0)), Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileNameStatus.PathNameValid);
            this.Manager.Checkpoint("MS-FSA_R405");
            this.Manager.Checkpoint(@"[In Application Requests an Open of a File , Pseudocode for the operation is as follows:
                        Phase 6 -- Location of file:] Pseudocode for this search:For i = 1 to n-1:
                        If Open.GrantedAccess.FILE_TRAVERSE is not set and AccessCheck( SecurityContext, Link.File.SecurityDescriptor, FILE_TRAVERSE ) 
                        returns FALSE, the operation is not  failed with STATUS_ACCESS_DENIED in Windows.");
            this.Manager.Checkpoint("MS-FSA_R475");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return:CreateAction set to FILE_CREATED.");
            this.Manager.Checkpoint("MS-FSA_R474");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return :Status set to STATUS_SUCCESS.");
            this.Manager.Comment("reaching state \'S12\'");
            this.Manager.Comment("checking step \'return CreateFile/SUCCESS\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus)(0)), temp0, "return of CreateFile, state S12");
            this.Manager.Comment("reaching state \'S16\'");
            bool temp1;
            this.Manager.Comment("executing step \'call GetIsLinkFound(out _)\'");
            this.IFSAAdapterInstance.GetIsLinkFound(out temp1);
            this.Manager.Comment("reaching state \'S20\'");
            this.Manager.Comment("checking step \'return GetIsLinkFound/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp1, "isLinkFound of GetIsLinkFound, state S20");
            this.Manager.Comment("reaching state \'S24\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp2;
            this.Manager.Comment("executing step \'call SetFileLinkInfo(False,True)\'");
            temp2 = this.IFSAAdapterInstance.SetFileLinkInfo(false, true);
            this.Manager.Checkpoint("MS-FSA_R2974");
            this.Manager.Checkpoint("[In FileLinkInformation,Pseudocode for the operation is as follows:]The operation" +
                    " returns STATUS_SUCCESS.");
            this.Manager.Comment("reaching state \'S28\'");
            this.Manager.Comment("checking step \'return SetFileLinkInfo/SUCCESS\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus)(0)), temp2, "return of SetFileLinkInfo, state S28");
            this.Manager.Comment("reaching state \'S32\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Model)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Fsa)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.SetFileInformation)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.NonSmb)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Positive)]
        public void SetFileLinkInformationTestCaseS2() {
            this.Manager.BeginTest("SetFileLinkInformationTestCaseS2");
            this.Manager.Comment("reaching state \'S2\'");
            this.Manager.Comment("executing step \'call FsaInitial()\'");
            this.IFSAAdapterInstance.FsaInitial();
            this.Manager.Comment("reaching state \'S3\'");
            this.Manager.Comment("checking step \'return FsaInitial\'");
            this.Manager.Comment("reaching state \'S9\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp3;
            this.Manager.Comment("executing step \'call CreateFile(NORMAL,NON_DIRECTORY_FILE,NULL,GENERIC_WRITE,FILE" +
                    "_SHARE_WRITE,OPEN_IF,StreamIsFound,IsNotSymbolicLink,DataFile,PathNameValid)\'");
            temp3 = this.IFSAAdapterInstance.CreateFile(Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAttribute.NORMAL, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateOptions.NON_DIRECTORY_FILE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamTypeNameToOpen.NULL, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAccess.GENERIC_WRITE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.ShareAccess.FILE_SHARE_WRITE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateDisposition.OPEN_IF, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamFoundType)(0)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.SymbolicLinkType)(1)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileType)(0)), Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileNameStatus.PathNameValid);
            this.Manager.Checkpoint("MS-FSA_R405");
            this.Manager.Checkpoint(@"[In Application Requests an Open of a File , Pseudocode for the operation is as follows:
                        Phase 6 -- Location of file:] Pseudocode for this search:For i = 1 to n-1:
                        If Open.GrantedAccess.FILE_TRAVERSE is not set and AccessCheck( SecurityContext, Link.File.SecurityDescriptor, FILE_TRAVERSE ) 
                        returns FALSE, the operation is not  failed with STATUS_ACCESS_DENIED in Windows.");
            this.Manager.Checkpoint("MS-FSA_R475");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return:CreateAction set to FILE_CREATED.");
            this.Manager.Checkpoint("MS-FSA_R474");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return :Status set to STATUS_SUCCESS.");
            this.Manager.Comment("reaching state \'S13\'");
            this.Manager.Comment("checking step \'return CreateFile/SUCCESS\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus)(0)), temp3, "return of CreateFile, state S13");
            this.Manager.Comment("reaching state \'S17\'");
            bool temp4;
            this.Manager.Comment("executing step \'call GetIsLinkFound(out _)\'");
            this.IFSAAdapterInstance.GetIsLinkFound(out temp4);
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("checking step \'return GetIsLinkFound/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp4, "isLinkFound of GetIsLinkFound, state S21");
            this.Manager.Comment("reaching state \'S25\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp5;
            this.Manager.Comment("executing step \'call SetFileLinkInfo(True,True)\'");
            temp5 = this.IFSAAdapterInstance.SetFileLinkInfo(true, true);
            this.Manager.Checkpoint("MS-FSA_R2941");
            this.Manager.Checkpoint("[In FileLinkInformation,Pseudocode for the operation is as follows:]\r\n           " +
                    "         If InputBuffer.FileName is not valid as specified in [MS-FSCC] section " +
                    "2.1.5, the operation MUST be failed with STATUS_OBJECT_NAME_INVALID.");
            this.Manager.Comment("reaching state \'S29\'");
            this.Manager.Comment("checking step \'return SetFileLinkInfo/OBJECT_NAME_INVALID\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus.OBJECT_NAME_INVALID, temp5, "return of SetFileLinkInfo, state S29");
            this.Manager.Comment("reaching state \'S33\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S4
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Model)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Fsa)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.SetFileInformation)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.NonSmb)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Positive)]
        public void SetFileLinkInformationTestCaseS4() {
            this.Manager.BeginTest("SetFileLinkInformationTestCaseS4");
            this.Manager.Comment("reaching state \'S4\'");
            this.Manager.Comment("executing step \'call FsaInitial()\'");
            this.IFSAAdapterInstance.FsaInitial();
            this.Manager.Comment("reaching state \'S5\'");
            this.Manager.Comment("checking step \'return FsaInitial\'");
            this.Manager.Comment("reaching state \'S10\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp6;
            this.Manager.Comment("executing step \'call CreateFile(NORMAL,NON_DIRECTORY_FILE,NULL,GENERIC_WRITE,FILE" +
                    "_SHARE_WRITE,OPEN_IF,StreamIsFound,IsNotSymbolicLink,DataFile,PathNameValid)\'");
            temp6 = this.IFSAAdapterInstance.CreateFile(Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAttribute.NORMAL, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateOptions.NON_DIRECTORY_FILE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamTypeNameToOpen.NULL, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAccess.GENERIC_WRITE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.ShareAccess.FILE_SHARE_WRITE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateDisposition.OPEN_IF, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamFoundType)(0)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.SymbolicLinkType)(1)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileType)(0)), Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileNameStatus.PathNameValid);
            this.Manager.Checkpoint("MS-FSA_R405");
            this.Manager.Checkpoint(@"[In Application Requests an Open of a File , Pseudocode for the operation is as follows:
                        Phase 6 -- Location of file:] Pseudocode for this search:For i = 1 to n-1:
                        If Open.GrantedAccess.FILE_TRAVERSE is not set and AccessCheck( SecurityContext, Link.File.SecurityDescriptor, FILE_TRAVERSE ) 
                        returns FALSE, the operation is not  failed with STATUS_ACCESS_DENIED in Windows.");
            this.Manager.Checkpoint("MS-FSA_R475");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return:CreateAction set to FILE_CREATED.");
            this.Manager.Checkpoint("MS-FSA_R474");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return :Status set to STATUS_SUCCESS.");
            this.Manager.Comment("reaching state \'S14\'");
            this.Manager.Comment("checking step \'return CreateFile/SUCCESS\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus)(0)), temp6, "return of CreateFile, state S14");
            this.Manager.Comment("reaching state \'S18\'");
            bool temp7;
            this.Manager.Comment("executing step \'call GetIsLinkFound(out _)\'");
            this.IFSAAdapterInstance.GetIsLinkFound(out temp7);
            this.Manager.Comment("reaching state \'S22\'");
            this.Manager.Comment("checking step \'return GetIsLinkFound/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp7, "isLinkFound of GetIsLinkFound, state S22");
            this.Manager.Comment("reaching state \'S26\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp8;
            this.Manager.Comment("executing step \'call SetFileLinkInfo(True,False)\'");
            temp8 = this.IFSAAdapterInstance.SetFileLinkInfo(true, false);
            this.Manager.Checkpoint("MS-FSA_R2941");
            this.Manager.Checkpoint("[In FileLinkInformation,Pseudocode for the operation is as follows:]\r\n           " +
                    "         If InputBuffer.FileName is not valid as specified in [MS-FSCC] section " +
                    "2.1.5, the operation MUST be failed with STATUS_OBJECT_NAME_INVALID.");
            this.Manager.Comment("reaching state \'S30\'");
            this.Manager.Comment("checking step \'return SetFileLinkInfo/OBJECT_NAME_INVALID\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus.OBJECT_NAME_INVALID, temp8, "return of SetFileLinkInfo, state S30");
            this.Manager.Comment("reaching state \'S34\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S6
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Model)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Fsa)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.SetFileInformation)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.NonSmb)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Positive)]
        public void SetFileLinkInformationTestCaseS6() {
            this.Manager.BeginTest("SetFileLinkInformationTestCaseS6");
            this.Manager.Comment("reaching state \'S6\'");
            this.Manager.Comment("executing step \'call FsaInitial()\'");
            this.IFSAAdapterInstance.FsaInitial();
            this.Manager.Comment("reaching state \'S7\'");
            this.Manager.Comment("checking step \'return FsaInitial\'");
            this.Manager.Comment("reaching state \'S11\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp9;
            this.Manager.Comment("executing step \'call CreateFile(NORMAL,NON_DIRECTORY_FILE,NULL,GENERIC_WRITE,FILE" +
                    "_SHARE_WRITE,OPEN_IF,StreamIsFound,IsNotSymbolicLink,DataFile,PathNameValid)\'");
            temp9 = this.IFSAAdapterInstance.CreateFile(Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAttribute.NORMAL, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateOptions.NON_DIRECTORY_FILE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamTypeNameToOpen.NULL, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAccess.GENERIC_WRITE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.ShareAccess.FILE_SHARE_WRITE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateDisposition.OPEN_IF, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamFoundType)(0)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.SymbolicLinkType)(1)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileType)(0)), Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileNameStatus.PathNameValid);
            this.Manager.Checkpoint("MS-FSA_R405");
            this.Manager.Checkpoint(@"[In Application Requests an Open of a File , Pseudocode for the operation is as follows:
                        Phase 6 -- Location of file:] Pseudocode for this search:For i = 1 to n-1:
                        If Open.GrantedAccess.FILE_TRAVERSE is not set and AccessCheck( SecurityContext, Link.File.SecurityDescriptor, FILE_TRAVERSE ) 
                        returns FALSE, the operation is not  failed with STATUS_ACCESS_DENIED in Windows.");
            this.Manager.Checkpoint("MS-FSA_R475");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return:CreateAction set to FILE_CREATED.");
            this.Manager.Checkpoint("MS-FSA_R474");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return :Status set to STATUS_SUCCESS.");
            this.Manager.Comment("reaching state \'S15\'");
            this.Manager.Comment("checking step \'return CreateFile/SUCCESS\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus)(0)), temp9, "return of CreateFile, state S15");
            this.Manager.Comment("reaching state \'S19\'");
            bool temp10;
            this.Manager.Comment("executing step \'call GetIsLinkFound(out _)\'");
            this.IFSAAdapterInstance.GetIsLinkFound(out temp10);
            this.Manager.Comment("reaching state \'S23\'");
            this.Manager.Comment("checking step \'return GetIsLinkFound/[out True]\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp10, "isLinkFound of GetIsLinkFound, state S23");
            this.Manager.Comment("reaching state \'S27\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp11;
            this.Manager.Comment("executing step \'call SetFileLinkInfo(False,False)\'");
            temp11 = this.IFSAAdapterInstance.SetFileLinkInfo(false, false);
            this.Manager.Checkpoint("MS-FSA_R2954");
            this.Manager.Checkpoint("[In FileLinkInformation,Pseudocode for the operation is as follows: \r\n           " +
                    "             If such a link is found:]Else[If InputBuffer.ReplaceIfExists is FAL" +
                    "SE]The operation MUST be failed with STATUS_OBJECT_NAME_COLLISION.");
            this.Manager.Comment("reaching state \'S31\'");
            this.Manager.Comment("checking step \'return SetFileLinkInfo/OBJECT_NAME_COLLISION\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus.OBJECT_NAME_COLLISION, temp11, "return of SetFileLinkInfo, state S31");
            this.Manager.Comment("reaching state \'S35\'");
            this.Manager.EndTest();
        }
        #endregion
    }
}
