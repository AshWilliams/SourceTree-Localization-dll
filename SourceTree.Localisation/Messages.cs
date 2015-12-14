using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
namespace SourceTree.Localisation
{
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
    public class Messages
    {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static ResourceManager ResourceManager
        {
            get
            {
                if (Messages.resourceMan == null)
                {
                    Messages.resourceMan = new ResourceManager("SourceTree.Localisation.Messages", typeof(Messages).Assembly);
                }
                return Messages.resourceMan;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture
        {
            get
            {
                return Messages.resourceCulture;
            }
            set
            {
                Messages.resourceCulture = value;
            }
        }
        public static string AlreadyRegisteredWarningMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("AlreadyRegisteredWarningMsg", Messages.resourceCulture);
            }
        }
        public static string AlreadyRegisteredWarningTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("AlreadyRegisteredWarningTitle", Messages.resourceCulture);
            }
        }
        public static string AlreadyResolvedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("AlreadyResolvedMsg", Messages.resourceCulture);
            }
        }
        public static string AlreadyResolvedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("AlreadyResolvedTitle", Messages.resourceCulture);
            }
        }
        public static string ApiAuthenticationErrorMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ApiAuthenticationErrorMsg", Messages.resourceCulture);
            }
        }
        public static string ApplyPatchRejectionsMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ApplyPatchRejectionsMsg", Messages.resourceCulture);
            }
        }
        public static string ApplyPatchRejectionsTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ApplyPatchRejectionsTitle", Messages.resourceCulture);
            }
        }
        public static string AskBrowseForSshKeyMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("AskBrowseForSshKeyMsg", Messages.resourceCulture);
            }
        }
        public static string AskBrowseForSshKeyTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("AskBrowseForSshKeyTitle", Messages.resourceCulture);
            }
        }
        public static string BookmarksPlaceholder
        {
            get
            {
                return Messages.ResourceManager.GetString("BookmarksPlaceholder", Messages.resourceCulture);
            }
        }
        public static string BrowseDefaultFolderTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("BrowseDefaultFolderTitle", Messages.resourceCulture);
            }
        }
        public static string BrowseForLicenseFile
        {
            get
            {
                return Messages.ResourceManager.GetString("BrowseForLicenseFile", Messages.resourceCulture);
            }
        }
        public static string BrowseForSpecificFileTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("BrowseForSpecificFileTitle", Messages.resourceCulture);
            }
        }
        public static string BrowseGlobalIgnoreFileTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("BrowseGlobalIgnoreFileTitle", Messages.resourceCulture);
            }
        }
        public static string BrowseOpenSSHKeyFileMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("BrowseOpenSSHKeyFileMsg", Messages.resourceCulture);
            }
        }
        public static string BrowseScriptTargetTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("BrowseScriptTargetTitle", Messages.resourceCulture);
            }
        }
        public static string BrowseSSHPuttyKeyFileMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("BrowseSSHPuttyKeyFileMsg", Messages.resourceCulture);
            }
        }
        public static string ChangeFolder
        {
            get
            {
                return Messages.ResourceManager.GetString("ChangeFolder", Messages.resourceCulture);
            }
        }
        public static string ChangeSubmoduleSourceTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ChangeSubmoduleSourceTitle", Messages.resourceCulture);
            }
        }
        public static string ChangeSubrepoSourceTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ChangeSubrepoSourceTitle", Messages.resourceCulture);
            }
        }
        public static string CheckForUpdateDone
        {
            get
            {
                return Messages.ResourceManager.GetString("CheckForUpdateDone", Messages.resourceCulture);
            }
        }
        public static string CheckForUpdateErrorMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("CheckForUpdateErrorMsg", Messages.resourceCulture);
            }
        }
        public static string CheckForUpdateInProgress
        {
            get
            {
                return Messages.ResourceManager.GetString("CheckForUpdateInProgress", Messages.resourceCulture);
            }
        }
        public static string CheckForUpdatesErrorTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("CheckForUpdatesErrorTitle", Messages.resourceCulture);
            }
        }
        public static string CheckoutUrlLocalBranchExistsMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("CheckoutUrlLocalBranchExistsMsg", Messages.resourceCulture);
            }
        }
        public static string CheckoutUrlLocalBranchExistsTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("CheckoutUrlLocalBranchExistsTitle", Messages.resourceCulture);
            }
        }
        public static string CloneCheckingSource
        {
            get
            {
                return Messages.ResourceManager.GetString("CloneCheckingSource", Messages.resourceCulture);
            }
        }
        public static string CloneDirErrorMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("CloneDirErrorMsg", Messages.resourceCulture);
            }
        }
        public static string CloneDirErrorTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("CloneDirErrorTitle", Messages.resourceCulture);
            }
        }
        public static string CloneDirNotEmptyMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("CloneDirNotEmptyMsg", Messages.resourceCulture);
            }
        }
        public static string CloneDirNotEmptyTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("CloneDirNotEmptyTitle", Messages.resourceCulture);
            }
        }
        public static string CloneNoSourceSupplied
        {
            get
            {
                return Messages.ResourceManager.GetString("CloneNoSourceSupplied", Messages.resourceCulture);
            }
        }
        public static string CommandLineHelp
        {
            get
            {
                return Messages.ResourceManager.GetString("CommandLineHelp", Messages.resourceCulture);
            }
        }
        public static string CommandLineHelpTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("CommandLineHelpTitle", Messages.resourceCulture);
            }
        }
        public static string CommitAmendWarningMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("CommitAmendWarningMsg", Messages.resourceCulture);
            }
        }
        public static string CommitAmendWarningTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("CommitAmendWarningTitle", Messages.resourceCulture);
            }
        }
        public static string CommitRangeDetailsWorkingCopy
        {
            get
            {
                return Messages.ResourceManager.GetString("CommitRangeDetailsWorkingCopy", Messages.resourceCulture);
            }
        }
        public static string CommitTextLinkUrlErrorMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("CommitTextLinkUrlErrorMsg", Messages.resourceCulture);
            }
        }
        public static string CommitTextLinkUrlErrorTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("CommitTextLinkUrlErrorTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmAddFilesMessage
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmAddFilesMessage", Messages.resourceCulture);
            }
        }
        public static string ConfirmAddFilesTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmAddFilesTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmAddLargeFilesMessage
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmAddLargeFilesMessage", Messages.resourceCulture);
            }
        }
        public static string ConfirmAddLargeFilesTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmAddLargeFilesTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmAddRemoveMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmAddRemoveMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmAddRemoveTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmAddRemoveTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmApplyShelfMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmApplyShelfMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmApplyShelfTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmApplyShelfTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmApplyStashMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmApplyStashMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmApplyStashTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmApplyStashTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmCherryPickMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmCherryPickMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmCherryPickTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmCherryPickTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmCloseBranchMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmCloseBranchMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmCloseBranchTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmCloseBranchTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteBranchMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteBranchMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteBranchTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteBranchTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteCustomActionMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteCustomActionMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteDefaultUsername
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteDefaultUsername", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteHostedAccountMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteHostedAccountMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeletePassword
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeletePassword", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteRemoteBranchMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteRemoteBranchMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteRemoteBranchTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteRemoteBranchTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteShelfMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteShelfMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteStashMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteStashMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteSubtreeMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteSubtreeMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteSubtreeTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteSubtreeTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteTagMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteTagMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteTagTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteTagTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmDeleteTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDeleteTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmDiscardHunkMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDiscardHunkMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDiscardHunkOrLinesTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDiscardHunkOrLinesTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmDiscardLinesMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDiscardLinesMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDiscardMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDiscardMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmDiscardTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmDiscardTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmLinkSubtreeMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmLinkSubtreeMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmLinkSubtreeTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmLinkSubtreeTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmMarkResolvedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmMarkResolvedMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmMarkResolvedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmMarkResolvedTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmMarkUnresolvedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmMarkUnresolvedMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmMarkUnresolvedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmMarkUnresolvedTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmMergeMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmMergeMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmMergeTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmMergeTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmPullSubtreeMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmPullSubtreeMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmPullSubtreeTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmPullSubtreeTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmPushSubtreeMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmPushSubtreeMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmPushSubtreeTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmPushSubtreeTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmPushTagMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmPushTagMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmPushTagTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmPushTagTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmRebaseMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRebaseMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmRebaseTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRebaseTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemove
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemove", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemoveFilesMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemoveFilesMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemoveNamedRemoteMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemoveNamedRemoteMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemoveNodesMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemoveNodesMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemoveRemoteMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemoveRemoteMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemoveRemoteTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemoveRemoteTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemoveRepo
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemoveRepo", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemoveRepoMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemoveRepoMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemoveRepoWithUnrecoverableFilesMessage
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemoveRepoWithUnrecoverableFilesMessage", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemoveUnrecoverableFilesMessage
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemoveUnrecoverableFilesMessage", Messages.resourceCulture);
            }
        }
        public static string ConfirmRemoveUnrecoverableFilesTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRemoveUnrecoverableFilesTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmReplaceCommitTextMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmReplaceCommitTextMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmReplaceCommitTextTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmReplaceCommitTextTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmResetAllMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmResetAllMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmResetAllTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmResetAllTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmResetBranchHardMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmResetBranchHardMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmResetBranchHardTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmResetBranchHardTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmResetFilesToCommitMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmResetFilesToCommitMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmResetFilesToCommitTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmResetFilesToCommitTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmResolveMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmResolveMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmResolveRebaseMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmResolveRebaseMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmResolveTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmResolveTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmRestartMergeMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRestartMergeMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmRestartMergeTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmRestartMergeTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmReverseCommitMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmReverseCommitMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmReverseCommitTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmReverseCommitTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmStopTrackingFilesMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmStopTrackingFilesMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmStopTrackingFilesTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmStopTrackingFilesTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmStripMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmStripMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmStripTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmStripTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmSwitchBranchMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmSwitchBranchMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmSwitchBranchTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmSwitchBranchTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmTrackRemoteBranchMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmTrackRemoteBranchMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmTrackRemoteBranchTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmTrackRemoteBranchTitle", Messages.resourceCulture);
            }
        }
        public static string ConfirmUpdateToMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmUpdateToMsg", Messages.resourceCulture);
            }
        }
        public static string ConfirmUpdateToTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConfirmUpdateToTitle", Messages.resourceCulture);
            }
        }
        public static string ConflictsWarningMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ConflictsWarningMsg", Messages.resourceCulture);
            }
        }
        public static string ConflictsWarningTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ConflictsWarningTitle", Messages.resourceCulture);
            }
        }
        public static string CrashDialogMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("CrashDialogMsg", Messages.resourceCulture);
            }
        }
        public static string CrashDialogTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("CrashDialogTitle", Messages.resourceCulture);
            }
        }
        public static string CreateGitTag
        {
            get
            {
                return Messages.ResourceManager.GetString("CreateGitTag", Messages.resourceCulture);
            }
        }
        public static string CreatePullRequestNoProjectLinkMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("CreatePullRequestNoProjectLinkMsg", Messages.resourceCulture);
            }
        }
        public static string CreatePullRequestNoProjectLinkTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("CreatePullRequestNoProjectLinkTitle", Messages.resourceCulture);
            }
        }
        public static string CreateRepoFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("CreateRepoFailedMsg", Messages.resourceCulture);
            }
        }
        public static string CreateRepoFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("CreateRepoFailedTitle", Messages.resourceCulture);
            }
        }
        public static string CreateSvnTag
        {
            get
            {
                return Messages.ResourceManager.GetString("CreateSvnTag", Messages.resourceCulture);
            }
        }
        public static string CustomActionScriptBlankMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("CustomActionScriptBlankMsg", Messages.resourceCulture);
            }
        }
        public static string DeleteAfterApplying
        {
            get
            {
                return Messages.ResourceManager.GetString("DeleteAfterApplying", Messages.resourceCulture);
            }
        }
        public static string DeleteBranchNoneSelectedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("DeleteBranchNoneSelectedMsg", Messages.resourceCulture);
            }
        }
        public static string DeleteBranchNoneSelectedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("DeleteBranchNoneSelectedTitle", Messages.resourceCulture);
            }
        }
        public static string DeleteReposOnFileSystem
        {
            get
            {
                return Messages.ResourceManager.GetString("DeleteReposOnFileSystem", Messages.resourceCulture);
            }
        }
        public static string DetailsAuthor
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsAuthor", Messages.resourceCulture);
            }
        }
        public static string DetailsBranch
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsBranch", Messages.resourceCulture);
            }
        }
        public static string DetailsChangeset
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsChangeset", Messages.resourceCulture);
            }
        }
        public static string DetailsCommit
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsCommit", Messages.resourceCulture);
            }
        }
        public static string DetailsCommittedDate
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsCommittedDate", Messages.resourceCulture);
            }
        }
        public static string DetailsCommitter
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsCommitter", Messages.resourceCulture);
            }
        }
        public static string DetailsDate
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsDate", Messages.resourceCulture);
            }
        }
        public static string DetailsLabels
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsLabels", Messages.resourceCulture);
            }
        }
        public static string DetailsParents
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsParents", Messages.resourceCulture);
            }
        }
        public static string DetailsRevision
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsRevision", Messages.resourceCulture);
            }
        }
        public static string DetailsSVNRevision
        {
            get
            {
                return Messages.ResourceManager.GetString("DetailsSVNRevision", Messages.resourceCulture);
            }
        }
        public static string DiscardNoFilesSelectedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("DiscardNoFilesSelectedMsg", Messages.resourceCulture);
            }
        }
        public static string DiscardNoFilesSelectedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("DiscardNoFilesSelectedTitle", Messages.resourceCulture);
            }
        }
        public static string DontAskMeAgain
        {
            get
            {
                return Messages.ResourceManager.GetString("DontAskMeAgain", Messages.resourceCulture);
            }
        }
        public static string DownloadEmbeddedAgainMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("DownloadEmbeddedAgainMsg", Messages.resourceCulture);
            }
        }
        public static string DownloadEmbeddedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("DownloadEmbeddedMsg", Messages.resourceCulture);
            }
        }
        public static string DownloadEmbeddedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("DownloadEmbeddedTitle", Messages.resourceCulture);
            }
        }
        public static string DownloadFailedOrAbortedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("DownloadFailedOrAbortedMsg", Messages.resourceCulture);
            }
        }
        public static string DownloadFailedOrAbortedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("DownloadFailedOrAbortedTitle", Messages.resourceCulture);
            }
        }
        public static string DownloadingMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("DownloadingMsg", Messages.resourceCulture);
            }
        }
        public static string DownloadingTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("DownloadingTitle", Messages.resourceCulture);
            }
        }
        public static string DuplicateRemoteNameMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("DuplicateRemoteNameMsg", Messages.resourceCulture);
            }
        }
        public static string DuplicateRemoteNameTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("DuplicateRemoteNameTitle", Messages.resourceCulture);
            }
        }
        public static string DuplicateTagMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("DuplicateTagMsg", Messages.resourceCulture);
            }
        }
        public static string DuplicateTagTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("DuplicateTagTitle", Messages.resourceCulture);
            }
        }
        public static string EmptyCommitMessage
        {
            get
            {
                return Messages.ResourceManager.GetString("EmptyCommitMessage", Messages.resourceCulture);
            }
        }
        public static string EmptyCommitMessageTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("EmptyCommitMessageTitle", Messages.resourceCulture);
            }
        }
        public static string EnterUserDetails
        {
            get
            {
                return Messages.ResourceManager.GetString("EnterUserDetails", Messages.resourceCulture);
            }
        }
        public static string ErrorTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ErrorTitle", Messages.resourceCulture);
            }
        }
        public static string ExtractFileFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ExtractFileFailedMsg", Messages.resourceCulture);
            }
        }
        public static string ExtractFileFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ExtractFileFailedTitle", Messages.resourceCulture);
            }
        }
        public static string ExtractingFile
        {
            get
            {
                return Messages.ResourceManager.GetString("ExtractingFile", Messages.resourceCulture);
            }
        }
        public static string FlowInitConfirmTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("FlowInitConfirmTitle", Messages.resourceCulture);
            }
        }
        public static string FlowInitHgConfirmMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("FlowInitHgConfirmMsg", Messages.resourceCulture);
            }
        }
        public static string FlowNoProductionBranchMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("FlowNoProductionBranchMsg", Messages.resourceCulture);
            }
        }
        public static string FlowNoProductionBranchTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("FlowNoProductionBranchTitle", Messages.resourceCulture);
            }
        }
        public static string ForceDelete
        {
            get
            {
                return Messages.ResourceManager.GetString("ForceDelete", Messages.resourceCulture);
            }
        }
        public static string GitFlowInstallFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("GitFlowInstallFailedMsg", Messages.resourceCulture);
            }
        }
        public static string GitFlowInstallFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("GitFlowInstallFailedTitle", Messages.resourceCulture);
            }
        }
        public static string GitNotEnabledMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("GitNotEnabledMsg", Messages.resourceCulture);
            }
        }
        public static string GitNotEnabledTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("GitNotEnabledTitle", Messages.resourceCulture);
            }
        }
        public static string GitNotFoundCheckAgain
        {
            get
            {
                return Messages.ResourceManager.GetString("GitNotFoundCheckAgain", Messages.resourceCulture);
            }
        }
        public static string GitNotFoundDontInstall
        {
            get
            {
                return Messages.ResourceManager.GetString("GitNotFoundDontInstall", Messages.resourceCulture);
            }
        }
        public static string GitNotFoundDownload
        {
            get
            {
                return Messages.ResourceManager.GetString("GitNotFoundDownload", Messages.resourceCulture);
            }
        }
        public static string GitNotFoundMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("GitNotFoundMsg", Messages.resourceCulture);
            }
        }
        public static string GitNotFoundSpecifyLocation
        {
            get
            {
                return Messages.ResourceManager.GetString("GitNotFoundSpecifyLocation", Messages.resourceCulture);
            }
        }
        public static string GitNotFoundTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("GitNotFoundTitle", Messages.resourceCulture);
            }
        }
        public static string GitRemoteUncPathWarning
        {
            get
            {
                return Messages.ResourceManager.GetString("GitRemoteUncPathWarning", Messages.resourceCulture);
            }
        }
        public static string GitRepoIdentified
        {
            get
            {
                return Messages.ResourceManager.GetString("GitRepoIdentified", Messages.resourceCulture);
            }
        }
        public static string GitSvnCreateBranchMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("GitSvnCreateBranchMsg", Messages.resourceCulture);
            }
        }
        public static string GitSvnCreateBranchTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("GitSvnCreateBranchTitle", Messages.resourceCulture);
            }
        }
        public static string GitSvnMergeMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("GitSvnMergeMsg", Messages.resourceCulture);
            }
        }
        public static string GitSvnMergeTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("GitSvnMergeTitle", Messages.resourceCulture);
            }
        }
        public static string GitSvnPushConfirmMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("GitSvnPushConfirmMsg", Messages.resourceCulture);
            }
        }
        public static string GitSvnPushConfirmTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("GitSvnPushConfirmTitle", Messages.resourceCulture);
            }
        }
        public static string GitSvnTagMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("GitSvnTagMsg", Messages.resourceCulture);
            }
        }
        public static string GitSvnTagTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("GitSvnTagTitle", Messages.resourceCulture);
            }
        }
        public static string GlobalIgnoreNotConfiguredMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("GlobalIgnoreNotConfiguredMsg", Messages.resourceCulture);
            }
        }
        public static string GlobalIgnoreNotConfiguredTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("GlobalIgnoreNotConfiguredTitle", Messages.resourceCulture);
            }
        }
        public static string GraftAbort
        {
            get
            {
                return Messages.ResourceManager.GetString("GraftAbort", Messages.resourceCulture);
            }
        }
        public static string GraftContinue
        {
            get
            {
                return Messages.ResourceManager.GetString("GraftContinue", Messages.resourceCulture);
            }
        }
        public static string GraftContinueAbortMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("GraftContinueAbortMsg", Messages.resourceCulture);
            }
        }
        public static string GraftContinueAbortTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("GraftContinueAbortTitle", Messages.resourceCulture);
            }
        }
        public static string GraftStatusText
        {
            get
            {
                return Messages.ResourceManager.GetString("GraftStatusText", Messages.resourceCulture);
            }
        }
        public static string HelloWorld
        {
            get
            {
                return Messages.ResourceManager.GetString("HelloWorld", Messages.resourceCulture);
            }
        }
        public static string HgNotEnabledMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HgNotEnabledMsg", Messages.resourceCulture);
            }
        }
        public static string HgNotEnabledTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HgNotEnabledTitle", Messages.resourceCulture);
            }
        }
        public static string HgNotFoundCheckAgain
        {
            get
            {
                return Messages.ResourceManager.GetString("HgNotFoundCheckAgain", Messages.resourceCulture);
            }
        }
        public static string HgNotFoundDontInstall
        {
            get
            {
                return Messages.ResourceManager.GetString("HgNotFoundDontInstall", Messages.resourceCulture);
            }
        }
        public static string HgNotFoundDownload
        {
            get
            {
                return Messages.ResourceManager.GetString("HgNotFoundDownload", Messages.resourceCulture);
            }
        }
        public static string HgNotFoundMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HgNotFoundMsg", Messages.resourceCulture);
            }
        }
        public static string HgNotFoundSpecifyLocation
        {
            get
            {
                return Messages.ResourceManager.GetString("HgNotFoundSpecifyLocation", Messages.resourceCulture);
            }
        }
        public static string HgNotFoundTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HgNotFoundTitle", Messages.resourceCulture);
            }
        }
        public static string HgSubversionCreateBranchMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HgSubversionCreateBranchMsg", Messages.resourceCulture);
            }
        }
        public static string HgSubversionCreateBranchTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HgSubversionCreateBranchTitle", Messages.resourceCulture);
            }
        }
        public static string HgSubversionMergeMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HgSubversionMergeMsg", Messages.resourceCulture);
            }
        }
        public static string HgSubversionMergeTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HgSubversionMergeTitle", Messages.resourceCulture);
            }
        }
        public static string HgSubversionTagMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HgSubversionTagMsg", Messages.resourceCulture);
            }
        }
        public static string HgSubversionTagTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HgSubversionTagTitle", Messages.resourceCulture);
            }
        }
        public static string HostAccountBadURLMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HostAccountBadURLMsg", Messages.resourceCulture);
            }
        }
        public static string HostAccountBadURLTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HostAccountBadURLTitle", Messages.resourceCulture);
            }
        }
        public static string HostAccountBadUsernameMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HostAccountBadUsernameMsg", Messages.resourceCulture);
            }
        }
        public static string HostAccountBadUsernameTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HostAccountBadUsernameTitle", Messages.resourceCulture);
            }
        }
        public static string HostAccountStashNoProjectsMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HostAccountStashNoProjectsMsg", Messages.resourceCulture);
            }
        }
        public static string HostAccountStashNoProjectsTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HostAccountStashNoProjectsTitle", Messages.resourceCulture);
            }
        }
        public static string HostAccountUsernameNotEmailMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HostAccountUsernameNotEmailMsg", Messages.resourceCulture);
            }
        }
        public static string HostedAccountLoginFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HostedAccountLoginFailedMsg", Messages.resourceCulture);
            }
        }
        public static string HostedAccountLoginFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HostedAccountLoginFailedTitle", Messages.resourceCulture);
            }
        }
        public static string HostingDetailsIncompleteMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HostingDetailsIncompleteMsg", Messages.resourceCulture);
            }
        }
        public static string HostingDetailsIncompleteTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HostingDetailsIncompleteTitle", Messages.resourceCulture);
            }
        }
        public static string HostLoginErrorMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("HostLoginErrorMsg", Messages.resourceCulture);
            }
        }
        public static string HostLoginErrorTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("HostLoginErrorTitle", Messages.resourceCulture);
            }
        }
        public static string IncorrectPrefixPathMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("IncorrectPrefixPathMsg", Messages.resourceCulture);
            }
        }
        public static string IncorrectPrefixPathTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("IncorrectPrefixPathTitle", Messages.resourceCulture);
            }
        }
        public static string InstallGlobalIgnoreFileMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("InstallGlobalIgnoreFileMsg", Messages.resourceCulture);
            }
        }
        public static string InstallGlobalIgnoreFileTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("InstallGlobalIgnoreFileTitle", Messages.resourceCulture);
            }
        }
        public static string InvalidEmailAddress
        {
            get
            {
                return Messages.ResourceManager.GetString("InvalidEmailAddress", Messages.resourceCulture);
            }
        }
        public static string InvalidEmailFormatMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("InvalidEmailFormatMsg", Messages.resourceCulture);
            }
        }
        public static string InvalidEmailFormatTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("InvalidEmailFormatTitle", Messages.resourceCulture);
            }
        }
        public static string InvalidPasswordMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("InvalidPasswordMsg", Messages.resourceCulture);
            }
        }
        public static string InvalidPasswordTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("InvalidPasswordTitle", Messages.resourceCulture);
            }
        }
        public static string InvalidPathMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("InvalidPathMsg", Messages.resourceCulture);
            }
        }
        public static string InvalidPathTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("InvalidPathTitle", Messages.resourceCulture);
            }
        }
        public static string JumpToCommitMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("JumpToCommitMsg", Messages.resourceCulture);
            }
        }
        public static string JumpToCommitTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("JumpToCommitTitle", Messages.resourceCulture);
            }
        }
        public static string LicenseAgreementMandatoryMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("LicenseAgreementMandatoryMsg", Messages.resourceCulture);
            }
        }
        public static string LicenseAgreementMandatorySkipSetupMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("LicenseAgreementMandatorySkipSetupMsg", Messages.resourceCulture);
            }
        }
        public static string LicenseAgreementMandatoryTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("LicenseAgreementMandatoryTitle", Messages.resourceCulture);
            }
        }
        public static string LicenseInvalidMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("LicenseInvalidMsg", Messages.resourceCulture);
            }
        }
        public static string LicenseInvalidTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("LicenseInvalidTitle", Messages.resourceCulture);
            }
        }
        public static string LoadingMessage
        {
            get
            {
                return Messages.ResourceManager.GetString("LoadingMessage", Messages.resourceCulture);
            }
        }
        public static string LocateMovedRepository
        {
            get
            {
                return Messages.ResourceManager.GetString("LocateMovedRepository", Messages.resourceCulture);
            }
        }
        public static string MercurialRepoIdentified
        {
            get
            {
                return Messages.ResourceManager.GetString("MercurialRepoIdentified", Messages.resourceCulture);
            }
        }
        public static string MergeStatusText
        {
            get
            {
                return Messages.ResourceManager.GetString("MergeStatusText", Messages.resourceCulture);
            }
        }
        public static string MissingFirstName
        {
            get
            {
                return Messages.ResourceManager.GetString("MissingFirstName", Messages.resourceCulture);
            }
        }
        public static string MissingLastName
        {
            get
            {
                return Messages.ResourceManager.GetString("MissingLastName", Messages.resourceCulture);
            }
        }
        public static string MissingPassword
        {
            get
            {
                return Messages.ResourceManager.GetString("MissingPassword", Messages.resourceCulture);
            }
        }
        public static string NewBranchAnnotation
        {
            get
            {
                return Messages.ResourceManager.GetString("NewBranchAnnotation", Messages.resourceCulture);
            }
        }
        public static string NewRepoDirNotEmptyMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("NewRepoDirNotEmptyMsg", Messages.resourceCulture);
            }
        }
        public static string NewRepoDirNotEmptyTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("NewRepoDirNotEmptyTitle", Messages.resourceCulture);
            }
        }
        public static string NoFilesSelectedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("NoFilesSelectedMsg", Messages.resourceCulture);
            }
        }
        public static string NoFilesSelectedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("NoFilesSelectedTitle", Messages.resourceCulture);
            }
        }
        public static string NoFilesToCommit
        {
            get
            {
                return Messages.ResourceManager.GetString("NoFilesToCommit", Messages.resourceCulture);
            }
        }
        public static string NoFilesToCommitMessage
        {
            get
            {
                return Messages.ResourceManager.GetString("NoFilesToCommitMessage", Messages.resourceCulture);
            }
        }
        public static string NoncontiguousStageSelectionMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("NoncontiguousStageSelectionMsg", Messages.resourceCulture);
            }
        }
        public static string NoncontiguousStageSelectionTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("NoncontiguousStageSelectionTitle", Messages.resourceCulture);
            }
        }
        public static string NoStagedChangesCommitAllMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("NoStagedChangesCommitAllMsg", Messages.resourceCulture);
            }
        }
        public static string NoStagedChangesCommitAllTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("NoStagedChangesCommitAllTitle", Messages.resourceCulture);
            }
        }
        public static string NoStagedChangesToCommit
        {
            get
            {
                return Messages.ResourceManager.GetString("NoStagedChangesToCommit", Messages.resourceCulture);
            }
        }
        public static string NoStagedChangesToCommitMessage
        {
            get
            {
                return Messages.ResourceManager.GetString("NoStagedChangesToCommitMessage", Messages.resourceCulture);
            }
        }
        public static string NotAValidRepoMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("NotAValidRepoMsg", Messages.resourceCulture);
            }
        }
        public static string NotAValidRepoTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("NotAValidRepoTitle", Messages.resourceCulture);
            }
        }
        public static string NotAValidSourcePathURL
        {
            get
            {
                return Messages.ResourceManager.GetString("NotAValidSourcePathURL", Messages.resourceCulture);
            }
        }
        public static string NotAValidWorkingCopy
        {
            get
            {
                return Messages.ResourceManager.GetString("NotAValidWorkingCopy", Messages.resourceCulture);
            }
        }
        public static string OpenRepositoryTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("OpenRepositoryTitle", Messages.resourceCulture);
            }
        }
        public static string OpenSourcePath
        {
            get
            {
                return Messages.ResourceManager.GetString("OpenSourcePath", Messages.resourceCulture);
            }
        }
        public static string OpenSshAgeantLaunchedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("OpenSshAgeantLaunchedMsg", Messages.resourceCulture);
            }
        }
        public static string OpenSSHAgentRunningButNoAccessMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("OpenSSHAgentRunningButNoAccessMsg", Messages.resourceCulture);
            }
        }
        public static string OpenSshKeyAuthFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("OpenSshKeyAuthFailedMsg", Messages.resourceCulture);
            }
        }
        public static string OpenWebBrowserFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("OpenWebBrowserFailedMsg", Messages.resourceCulture);
            }
        }
        public static string OpenWorkCopy
        {
            get
            {
                return Messages.ResourceManager.GetString("OpenWorkCopy", Messages.resourceCulture);
            }
        }
        public static string PageantKeyAuthFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("PageantKeyAuthFailedMsg", Messages.resourceCulture);
            }
        }
        public static string PageantLaunchedRetryMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("PageantLaunchedRetryMsg", Messages.resourceCulture);
            }
        }
        public static string PageantRunningButNoAccessMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("PageantRunningButNoAccessMsg", Messages.resourceCulture);
            }
        }
        public static string PasswordsDontMatch
        {
            get
            {
                return Messages.ResourceManager.GetString("PasswordsDontMatch", Messages.resourceCulture);
            }
        }
        public static string PatchConfirmedStrip
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchConfirmedStrip", Messages.resourceCulture);
            }
        }
        public static string PatchCouldntFindStripForFile
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchCouldntFindStripForFile", Messages.resourceCulture);
            }
        }
        public static string PatchDryRunOkMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchDryRunOkMsg", Messages.resourceCulture);
            }
        }
        public static string PatchDryRunOkTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchDryRunOkTitle", Messages.resourceCulture);
            }
        }
        public static string PatchFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchFailedMsg", Messages.resourceCulture);
            }
        }
        public static string PatchFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchFailedTitle", Messages.resourceCulture);
            }
        }
        public static string PatchIsBasicDiff
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchIsBasicDiff", Messages.resourceCulture);
            }
        }
        public static string PatchIsExtendedDiff
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchIsExtendedDiff", Messages.resourceCulture);
            }
        }
        public static string PatchIsGitCommit
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchIsGitCommit", Messages.resourceCulture);
            }
        }
        public static string PatchIsMercurialChangeset
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchIsMercurialChangeset", Messages.resourceCulture);
            }
        }
        public static string PatchIsNotAPatch
        {
            get
            {
                return Messages.ResourceManager.GetString("PatchIsNotAPatch", Messages.resourceCulture);
            }
        }
        public static string PickBranchMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("PickBranchMsg", Messages.resourceCulture);
            }
        }
        public static string PickBranchTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("PickBranchTitle", Messages.resourceCulture);
            }
        }
        public static string PickParentMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("PickParentMsg", Messages.resourceCulture);
            }
        }
        public static string PickParentTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("PickParentTitle", Messages.resourceCulture);
            }
        }
        public static string ProblemInstallingLicenseMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ProblemInstallingLicenseMsg", Messages.resourceCulture);
            }
        }
        public static string ProblemInstallingLicenseTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ProblemInstallingLicenseTitle", Messages.resourceCulture);
            }
        }
        public static string ProcessesCompletedSuccessfully
        {
            get
            {
                return Messages.ResourceManager.GetString("ProcessesCompletedSuccessfully", Messages.resourceCulture);
            }
        }
        public static string ProcessesCompletedWithErrors
        {
            get
            {
                return Messages.ResourceManager.GetString("ProcessesCompletedWithErrors", Messages.resourceCulture);
            }
        }
        public static string PushFromCommitFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("PushFromCommitFailedMsg", Messages.resourceCulture);
            }
        }
        public static string PushFromCommitFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("PushFromCommitFailedTitle", Messages.resourceCulture);
            }
        }
        public static string RebaseAbort
        {
            get
            {
                return Messages.ResourceManager.GetString("RebaseAbort", Messages.resourceCulture);
            }
        }
        public static string RebaseContinue
        {
            get
            {
                return Messages.ResourceManager.GetString("RebaseContinue", Messages.resourceCulture);
            }
        }
        public static string RebaseContinueAbortMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("RebaseContinueAbortMsg", Messages.resourceCulture);
            }
        }
        public static string RebaseContinueAbortTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("RebaseContinueAbortTitle", Messages.resourceCulture);
            }
        }
        public static string RebaseStatusText
        {
            get
            {
                return Messages.ResourceManager.GetString("RebaseStatusText", Messages.resourceCulture);
            }
        }
        public static string RegisterApiErrorMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("RegisterApiErrorMsg", Messages.resourceCulture);
            }
        }
        public static string RegisterApiErrorTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("RegisterApiErrorTitle", Messages.resourceCulture);
            }
        }
        public static string RemoteProjectLinkBaseURLInvalid
        {
            get
            {
                return Messages.ResourceManager.GetString("RemoteProjectLinkBaseURLInvalid", Messages.resourceCulture);
            }
        }
        public static string RemoteProjectLinkValidationMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("RemoteProjectLinkValidationMsg", Messages.resourceCulture);
            }
        }
        public static string RemoteUrlCannotMatchToRepoMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("RemoteUrlCannotMatchToRepoMsg", Messages.resourceCulture);
            }
        }
        public static string RemoteUrlCannotMatchToRepoTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("RemoteUrlCannotMatchToRepoTitle", Messages.resourceCulture);
            }
        }
        public static string RemoteUrlNotARepoMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("RemoteUrlNotARepoMsg", Messages.resourceCulture);
            }
        }
        public static string RemoteUrlNotARepoTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("RemoteUrlNotARepoTitle", Messages.resourceCulture);
            }
        }
        public static string RemoveBookmark
        {
            get
            {
                return Messages.ResourceManager.GetString("RemoveBookmark", Messages.resourceCulture);
            }
        }
        public static string RemoveBookmarks
        {
            get
            {
                return Messages.ResourceManager.GetString("RemoveBookmarks", Messages.resourceCulture);
            }
        }
        public static string RepoApiErrorsMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("RepoApiErrorsMsg", Messages.resourceCulture);
            }
        }
        public static string RepoApiErrorsTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("RepoApiErrorsTitle", Messages.resourceCulture);
            }
        }
        public static string RepoIsGone
        {
            get
            {
                return Messages.ResourceManager.GetString("RepoIsGone", Messages.resourceCulture);
            }
        }
        public static string RepoIsGoneMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("RepoIsGoneMsg", Messages.resourceCulture);
            }
        }
        public static string ReverseFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ReverseFailedMsg", Messages.resourceCulture);
            }
        }
        public static string ReverseFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ReverseFailedTitle", Messages.resourceCulture);
            }
        }
        public static string RevisionDetailsForMultipleSelection
        {
            get
            {
                return Messages.ResourceManager.GetString("RevisionDetailsForMultipleSelection", Messages.resourceCulture);
            }
        }
        public static string SavePasswordErrorMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("SavePasswordErrorMsg", Messages.resourceCulture);
            }
        }
        public static string SavePasswordErrorTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("SavePasswordErrorTitle", Messages.resourceCulture);
            }
        }
        public static string SetDestinationPath
        {
            get
            {
                return Messages.ResourceManager.GetString("SetDestinationPath", Messages.resourceCulture);
            }
        }
        public static string SshAgentLaunchedRetryTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("SshAgentLaunchedRetryTitle", Messages.resourceCulture);
            }
        }
        public static string SSHAuthFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("SSHAuthFailedTitle", Messages.resourceCulture);
            }
        }
        public static string SshKeyAuthFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("SshKeyAuthFailedTitle", Messages.resourceCulture);
            }
        }
        public static string SSHProblemAcceptingKeyMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("SSHProblemAcceptingKeyMsg", Messages.resourceCulture);
            }
        }
        public static string SSHProblemAcceptingKeyTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("SSHProblemAcceptingKeyTitle", Messages.resourceCulture);
            }
        }
        public static string SSHServerKeyChangedPromptMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("SSHServerKeyChangedPromptMsg", Messages.resourceCulture);
            }
        }
        public static string SSHServerKeyPromptMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("SSHServerKeyPromptMsg", Messages.resourceCulture);
            }
        }
        public static string SSHServerKeyPromptTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("SSHServerKeyPromptTitle", Messages.resourceCulture);
            }
        }
        public static string SSLCertAcceptTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("SSLCertAcceptTitle", Messages.resourceCulture);
            }
        }
        public static string String2
        {
            get
            {
                return Messages.ResourceManager.GetString("String2", Messages.resourceCulture);
            }
        }
        public static string SubmoduleGitOnlyMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("SubmoduleGitOnlyMsg", Messages.resourceCulture);
            }
        }
        public static string SubmoduleGitOnlyTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("SubmoduleGitOnlyTitle", Messages.resourceCulture);
            }
        }
        public static string SubmoduleOutsideRepoMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("SubmoduleOutsideRepoMsg", Messages.resourceCulture);
            }
        }
        public static string SubmoduleOutsideRepoTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("SubmoduleOutsideRepoTitle", Messages.resourceCulture);
            }
        }
        public static string SubtreeDetailsMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("SubtreeDetailsMsg", Messages.resourceCulture);
            }
        }
        public static string SubtreeDetailsTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("SubtreeDetailsTitle", Messages.resourceCulture);
            }
        }
        public static string SubtreeSquashOption
        {
            get
            {
                return Messages.ResourceManager.GetString("SubtreeSquashOption", Messages.resourceCulture);
            }
        }
        public static string SvnRepoIdentified
        {
            get
            {
                return Messages.ResourceManager.GetString("SvnRepoIdentified", Messages.resourceCulture);
            }
        }
        public static string TagDetails
        {
            get
            {
                return Messages.ResourceManager.GetString("TagDetails", Messages.resourceCulture);
            }
        }
        public static string TaskFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("TaskFailedMsg", Messages.resourceCulture);
            }
        }
        public static string TaskFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("TaskFailedTitle", Messages.resourceCulture);
            }
        }
        public static string TaskWorkingDirNotValid
        {
            get
            {
                return Messages.ResourceManager.GetString("TaskWorkingDirNotValid", Messages.resourceCulture);
            }
        }
        public static string UnableToStartGitBash
        {
            get
            {
                return Messages.ResourceManager.GetString("UnableToStartGitBash", Messages.resourceCulture);
            }
        }
        public static string UncommittedChanges
        {
            get
            {
                return Messages.ResourceManager.GetString("UncommittedChanges", Messages.resourceCulture);
            }
        }
        public static string UpdateBeingApplied
        {
            get
            {
                return Messages.ResourceManager.GetString("UpdateBeingApplied", Messages.resourceCulture);
            }
        }
        public static string UpdateFailedMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("UpdateFailedMsg", Messages.resourceCulture);
            }
        }
        public static string UpdateFailedTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("UpdateFailedTitle", Messages.resourceCulture);
            }
        }
        public static string UpdateFileError
        {
            get
            {
                return Messages.ResourceManager.GetString("UpdateFileError", Messages.resourceCulture);
            }
        }
        public static string UpdateInProgress
        {
            get
            {
                return Messages.ResourceManager.GetString("UpdateInProgress", Messages.resourceCulture);
            }
        }
        public static string UpdateIsAvailable
        {
            get
            {
                return Messages.ResourceManager.GetString("UpdateIsAvailable", Messages.resourceCulture);
            }
        }
        public static string UpdateNotNecessary
        {
            get
            {
                return Messages.ResourceManager.GetString("UpdateNotNecessary", Messages.resourceCulture);
            }
        }
        public static string UrlHandlerErrorMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("UrlHandlerErrorMsg", Messages.resourceCulture);
            }
        }
        public static string UrlHandlerSuccessMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("UrlHandlerSuccessMsg", Messages.resourceCulture);
            }
        }
        public static string UrlHandlerTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("UrlHandlerTitle", Messages.resourceCulture);
            }
        }
        public static string UserDetailsIncompleteMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("UserDetailsIncompleteMsg", Messages.resourceCulture);
            }
        }
        public static string UserDetailsIncompleteTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("UserDetailsIncompleteTitle", Messages.resourceCulture);
            }
        }
        public static string ValidationErrorMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("ValidationErrorMsg", Messages.resourceCulture);
            }
        }
        public static string ValidationErrorTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("ValidationErrorTitle", Messages.resourceCulture);
            }
        }
        public static string WarnCheckoutDetachedHeadMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("WarnCheckoutDetachedHeadMsg", Messages.resourceCulture);
            }
        }
        public static string WarnCheckoutDetachedHeadTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("WarnCheckoutDetachedHeadTitle", Messages.resourceCulture);
            }
        }
        public static string WarnLeavingDetachedHeadMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("WarnLeavingDetachedHeadMsg", Messages.resourceCulture);
            }
        }
        public static string WarnLeavingDetachedHeadTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("WarnLeavingDetachedHeadTitle", Messages.resourceCulture);
            }
        }
        public static string WarnWorkingCopyResetMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("WarnWorkingCopyResetMsg", Messages.resourceCulture);
            }
        }
        public static string WarnWorkingCopyResetTitle
        {
            get
            {
                return Messages.ResourceManager.GetString("WarnWorkingCopyResetTitle", Messages.resourceCulture);
            }
        }
        public static string WizardCheckApiLoginMsg
        {
            get
            {
                return Messages.ResourceManager.GetString("WizardCheckApiLoginMsg", Messages.resourceCulture);
            }
        }
        public static string WorkingCopyNotSupplied
        {
            get
            {
                return Messages.ResourceManager.GetString("WorkingCopyNotSupplied", Messages.resourceCulture);
            }
        }
        internal Messages()
        {
        }
    }
}
