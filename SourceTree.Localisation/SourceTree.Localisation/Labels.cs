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
	public class Labels
	{
		private static ResourceManager resourceMan;
		private static CultureInfo resourceCulture;
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager
		{
			get
			{
				if (Labels.resourceMan == null)
				{
					Labels.resourceMan = new ResourceManager("SourceTree.Localisation.Labels", typeof(Labels).Assembly);
				}
				return Labels.resourceMan;
			}
		}
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture
		{
			get
			{
				return Labels.resourceCulture;
			}
			set
			{
				Labels.resourceCulture = value;
			}
		}
		public static string Abort
		{
			get
			{
				return Labels.ResourceManager.GetString("Abort", Labels.resourceCulture);
			}
		}
		public static string AbortGraftMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("AbortGraftMenu", Labels.resourceCulture);
			}
		}
		public static string AbortRebaseMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("AbortRebaseMenu", Labels.resourceCulture);
			}
		}
		public static string About
		{
			get
			{
                return Labels.ResourceManager.GetString("About", Labels.resourceCulture);
			}
		}
		public static string AboutMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("AboutMenu", Labels.resourceCulture);
			}
		}
		public static string AboutSourceTree
		{
			get
			{
                return "Robert Rozas Navarro";//Labels.ResourceManager.GetString("AboutSourceTree", Labels.resourceCulture);
			}
		}
		public static string Account
		{
			get
			{
				return Labels.ResourceManager.GetString("Account", Labels.resourceCulture);
			}
		}
		public static string Action
		{
			get
			{
				return Labels.ResourceManager.GetString("Action", Labels.resourceCulture);
			}
		}
		public static string ActionsMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ActionsMenu", Labels.resourceCulture);
			}
		}
		public static string Add
		{
			get
			{
				return Labels.ResourceManager.GetString("Add", Labels.resourceCulture);
			}
		}
		public static string AddAccountTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("AddAccountTitle", Labels.resourceCulture);
			}
		}
		public static string AddFile
		{
			get
			{
				return Labels.ResourceManager.GetString("AddFile", Labels.resourceCulture);
			}
		}
		public static string AddFolder
		{
			get
			{
				return Labels.ResourceManager.GetString("AddFolder", Labels.resourceCulture);
			}
		}
		public static string AddLinkSubtreeLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("AddLinkSubtreeLabel", Labels.resourceCulture);
			}
		}
		public static string AddLinkSubtreeMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("AddLinkSubtreeMenu", Labels.resourceCulture);
			}
		}
		public static string AddLinkSubtreeTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("AddLinkSubtreeTitle", Labels.resourceCulture);
			}
		}
		public static string AddRemoteMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("AddRemoteMenu", Labels.resourceCulture);
			}
		}
		public static string AddRemove
		{
			get
			{
				return Labels.ResourceManager.GetString("AddRemove", Labels.resourceCulture);
			}
		}
		public static string AddRepository
		{
			get
			{
				return Labels.ResourceManager.GetString("AddRepository", Labels.resourceCulture);
			}
		}
		public static string AddSSHKeyMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("AddSSHKeyMenu", Labels.resourceCulture);
			}
		}
		public static string AddSubmodule
		{
			get
			{
				return Labels.ResourceManager.GetString("AddSubmodule", Labels.resourceCulture);
			}
		}
		public static string AddSubmoduleMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("AddSubmoduleMenu", Labels.resourceCulture);
			}
		}
		public static string AddSubrepoMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("AddSubrepoMenu", Labels.resourceCulture);
			}
		}
		public static string AddTag
		{
			get
			{
				return Labels.ResourceManager.GetString("AddTag", Labels.resourceCulture);
			}
		}
		public static string AddToDictionary
		{
			get
			{
				return Labels.ResourceManager.GetString("AddToDictionary", Labels.resourceCulture);
			}
		}
		public static string AddToIndex
		{
			get
			{
				return Labels.ResourceManager.GetString("AddToIndex", Labels.resourceCulture);
			}
		}
		public static string AddWorkingCopy
		{
			get
			{
				return Labels.ResourceManager.GetString("AddWorkingCopy", Labels.resourceCulture);
			}
		}
		public static string Advanced
		{
			get
			{
				return Labels.ResourceManager.GetString("Advanced", Labels.resourceCulture);
			}
		}
		public static string AdvancedOptions
		{
			get
			{
				return Labels.ResourceManager.GetString("AdvancedOptions", Labels.resourceCulture);
			}
		}
		public static string AfterPullingChangesLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("AfterPullingChangesLabel", Labels.resourceCulture);
			}
		}
		public static string AllBranches
		{
			get
			{
				return Labels.ResourceManager.GetString("AllBranches", Labels.resourceCulture);
			}
		}
		public static string AllFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("AllFiles", Labels.resourceCulture);
			}
		}
		public static string AllowModifyConfigFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("AllowModifyConfigFiles", Labels.resourceCulture);
			}
		}
		public static string AlwaysDisplayFullOutput
		{
			get
			{
				return Labels.ResourceManager.GetString("AlwaysDisplayFullOutput", Labels.resourceCulture);
			}
		}
		public static string AmendCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("AmendCommit", Labels.resourceCulture);
			}
		}
		public static string AnalyticsWindowTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("AnalyticsWindowTitle", Labels.resourceCulture);
			}
		}
		public static string AncestorOrder
		{
			get
			{
				return Labels.ResourceManager.GetString("AncestorOrder", Labels.resourceCulture);
			}
		}
		public static string ApplyPatch
		{
			get
			{
				return Labels.ResourceManager.GetString("ApplyPatch", Labels.resourceCulture);
			}
		}
		public static string ApplyPatchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ApplyPatchMenu", Labels.resourceCulture);
			}
		}
		public static string Archive
		{
			get
			{
				return Labels.ResourceManager.GetString("Archive", Labels.resourceCulture);
			}
		}
		public static string ArchiveFileLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ArchiveFileLabel", Labels.resourceCulture);
			}
		}
		public static string ArchiveMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ArchiveMenu", Labels.resourceCulture);
			}
		}
		public static string Arguments
		{
			get
			{
				return Labels.ResourceManager.GetString("Arguments", Labels.resourceCulture);
			}
		}
		public static string AskAQuestionMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("AskAQuestionMenu", Labels.resourceCulture);
			}
		}
		public static string Authentication
		{
			get
			{
				return Labels.ResourceManager.GetString("Authentication", Labels.resourceCulture);
			}
		}
		public static string AuthenticationPrefsDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("AuthenticationPrefsDesc", Labels.resourceCulture);
			}
		}
		public static string Author
		{
			get
			{
				return Labels.ResourceManager.GetString("Author", Labels.resourceCulture);
			}
		}
		public static string Authorheader
		{
			get
			{
				return Labels.ResourceManager.GetString("Authorheader", Labels.resourceCulture);
			}
		}
		public static string AuthorMapFile
		{
			get
			{
				return Labels.ResourceManager.GetString("AuthorMapFile", Labels.resourceCulture);
			}
		}
		public static string Automatic
		{
			get
			{
				return Labels.ResourceManager.GetString("Automatic", Labels.resourceCulture);
			}
		}
		public static string AutoRefreshPerRepo
		{
			get
			{
				return Labels.ResourceManager.GetString("AutoRefreshPerRepo", Labels.resourceCulture);
			}
		}
		public static string AvailableVersion
		{
			get
			{
				return Labels.ResourceManager.GetString("AvailableVersion", Labels.resourceCulture);
			}
		}
		public static string BasePathLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("BasePathLabel", Labels.resourceCulture);
			}
		}
		public static string BlameSelectedMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("BlameSelectedMenu", Labels.resourceCulture);
			}
		}
		public static string BlameWindowTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("BlameWindowTitle", Labels.resourceCulture);
			}
		}
		public static string BookmarkFolder
		{
			get
			{
				return Labels.ResourceManager.GetString("BookmarkFolder", Labels.resourceCulture);
			}
		}
		public static string BookmarkName
		{
			get
			{
				return Labels.ResourceManager.GetString("BookmarkName", Labels.resourceCulture);
			}
		}
		public static string BookmarkNameColumn
		{
			get
			{
				return Labels.ResourceManager.GetString("BookmarkNameColumn", Labels.resourceCulture);
			}
		}
		public static string BookmarkOpenRepositoriesMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("BookmarkOpenRepositoriesMenu", Labels.resourceCulture);
			}
		}
		public static string Bookmarks
		{
			get
			{
				return Labels.ResourceManager.GetString("Bookmarks", Labels.resourceCulture);
			}
		}
		public static string BookmarkThisRepository
		{
			get
			{
				return Labels.ResourceManager.GetString("BookmarkThisRepository", Labels.resourceCulture);
			}
		}
		public static string Branch
		{
			get
			{
				return Labels.ResourceManager.GetString("Branch", Labels.resourceCulture);
			}
		}
		public static string BranchDetails
		{
			get
			{
				return Labels.ResourceManager.GetString("BranchDetails", Labels.resourceCulture);
			}
		}
		public static string BranchesToPush
		{
			get
			{
				return Labels.ResourceManager.GetString("BranchesToPush", Labels.resourceCulture);
			}
		}
		public static string BranchLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("BranchLabel", Labels.resourceCulture);
			}
		}
		public static string BranchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("BranchMenu", Labels.resourceCulture);
			}
		}
		public static string Browse
		{
			get
			{
				return Labels.ResourceManager.GetString("Browse", Labels.resourceCulture);
			}
		}
		public static string BrowseHostedProjects
		{
			get
			{
				return Labels.ResourceManager.GetString("BrowseHostedProjects", Labels.resourceCulture);
			}
		}
		public static string BypassCommitHooks
		{
			get
			{
				return Labels.ResourceManager.GetString("BypassCommitHooks", Labels.resourceCulture);
			}
		}
		public static string Cancel
		{
			get
			{
				return Labels.ResourceManager.GetString("Cancel", Labels.resourceCulture);
			}
		}
		public static string ChangeFont
		{
			get
			{
				return Labels.ResourceManager.GetString("ChangeFont", Labels.resourceCulture);
			}
		}
		public static string ChangePassword
		{
			get
			{
				return Labels.ResourceManager.GetString("ChangePassword", Labels.resourceCulture);
			}
		}
		public static string Characters
		{
			get
			{
				return Labels.ResourceManager.GetString("Characters", Labels.resourceCulture);
			}
		}
		public static string CheckForUpdates
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckForUpdates", Labels.resourceCulture);
			}
		}
		public static string CheckingForExistingAccount
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckingForExistingAccount", Labels.resourceCulture);
			}
		}
		public static string CheckingPassword
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckingPassword", Labels.resourceCulture);
			}
		}
		public static string CheckingSubmodules
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckingSubmodules", Labels.resourceCulture);
			}
		}
		public static string CheckingSubrepositories
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckingSubrepositories", Labels.resourceCulture);
			}
		}
		public static string Checkout
		{
			get
			{
				return Labels.ResourceManager.GetString("Checkout", Labels.resourceCulture);
			}
		}
		public static string CheckoutBranchLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckoutBranchLabel", Labels.resourceCulture);
			}
		}
		public static string CheckoutExisting
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckoutExisting", Labels.resourceCulture);
			}
		}
		public static string CheckoutExistingHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckoutExistingHeader", Labels.resourceCulture);
			}
		}
		public static string CheckoutHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckoutHeader", Labels.resourceCulture);
			}
		}
		public static string CheckoutIntoLocalRepository
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckoutIntoLocalRepository", Labels.resourceCulture);
			}
		}
		public static string CheckoutMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckoutMenu", Labels.resourceCulture);
			}
		}
		public static string CheckoutNewBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckoutNewBranch", Labels.resourceCulture);
			}
		}
		public static string CheckoutRemoteBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckoutRemoteBranch", Labels.resourceCulture);
			}
		}
		public static string CheckRemotesAutomatically
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckRemotesAutomatically", Labels.resourceCulture);
			}
		}
		public static string CheckSubmodulesBeforeCommitPush
		{
			get
			{
				return Labels.ResourceManager.GetString("CheckSubmodulesBeforeCommitPush", Labels.resourceCulture);
			}
		}
		public static string CherryPickMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CherryPickMenu", Labels.resourceCulture);
			}
		}
		public static string ChooseFont
		{
			get
			{
				return Labels.ResourceManager.GetString("ChooseFont", Labels.resourceCulture);
			}
		}
		public static string CleanFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("CleanFiles", Labels.resourceCulture);
			}
		}
		public static string CleanOption
		{
			get
			{
				return Labels.ResourceManager.GetString("CleanOption", Labels.resourceCulture);
			}
		}
		public static string Clone
		{
			get
			{
				return Labels.ResourceManager.GetString("Clone", Labels.resourceCulture);
			}
		}
		public static string CloneAdvancedNoRepoText
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneAdvancedNoRepoText", Labels.resourceCulture);
			}
		}
		public static string CloneDepthLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneDepthLabel", Labels.resourceCulture);
			}
		}
		public static string CloneFirstRepoTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneFirstRepoTitle", Labels.resourceCulture);
			}
		}
		public static string CloneFromLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneFromLabel", Labels.resourceCulture);
			}
		}
		public static string CloneMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneMenu", Labels.resourceCulture);
			}
		}
		public static string CloneNew
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneNew", Labels.resourceCulture);
			}
		}
		public static string CloneNewMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneNewMenu", Labels.resourceCulture);
			}
		}
		public static string CloneNewRepo
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneNewRepo", Labels.resourceCulture);
			}
		}
		public static string CloneNewRepoHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneNewRepoHeader", Labels.resourceCulture);
			}
		}
		public static string CloneOnlyBranchLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneOnlyBranchLabel", Labels.resourceCulture);
			}
		}
		public static string CloneRepository
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneRepository", Labels.resourceCulture);
			}
		}
		public static string CloneToCommitLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("CloneToCommitLabel", Labels.resourceCulture);
			}
		}
		public static string Cloning
		{
			get
			{
				return Labels.ResourceManager.GetString("Cloning", Labels.resourceCulture);
			}
		}
		public static string Close
		{
			get
			{
				return Labels.ResourceManager.GetString("Close", Labels.resourceCulture);
			}
		}
		public static string CloseTabMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CloseTabMenu", Labels.resourceCulture);
			}
		}
		public static string Commit
		{
			get
			{
				return Labels.ResourceManager.GetString("Commit", Labels.resourceCulture);
			}
		}
		public static string CommitAllMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitAllMenu", Labels.resourceCulture);
			}
		}
		public static string CommitHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitHeader", Labels.resourceCulture);
			}
		}
		public static string CommitLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitLabel", Labels.resourceCulture);
			}
		}
		public static string CommitMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitMenu", Labels.resourceCulture);
			}
		}
		public static string CommitMergedChangesImmediately
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitMergedChangesImmediately", Labels.resourceCulture);
			}
		}
		public static string CommitMergeImmediately
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitMergeImmediately", Labels.resourceCulture);
			}
		}
		public static string CommitMessage
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitMessage", Labels.resourceCulture);
			}
		}
		public static string CommitMessageNoColon
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitMessageNoColon", Labels.resourceCulture);
			}
		}
		public static string CommitMode
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitMode", Labels.resourceCulture);
			}
		}
		public static string CommitModeSelectedFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitModeSelectedFiles", Labels.resourceCulture);
			}
		}
		public static string CommitModeStaged
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitModeStaged", Labels.resourceCulture);
			}
		}
		public static string CommitOptions
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitOptions", Labels.resourceCulture);
			}
		}
		public static string CommitSelectedMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitSelectedMenu", Labels.resourceCulture);
			}
		}
		public static string CommitTextReplacementDetails
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitTextReplacementDetails", Labels.resourceCulture);
			}
		}
		public static string CommitTextReplacements
		{
			get
			{
				return Labels.ResourceManager.GetString("CommitTextReplacements", Labels.resourceCulture);
			}
		}
		public static string CompanyLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("CompanyLabel", Labels.resourceCulture);
			}
		}
		public static string ConfirmPasswordLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ConfirmPasswordLabel", Labels.resourceCulture);
			}
		}
		public static string ConfirmStripKeepOption
		{
			get
			{
				return Labels.ResourceManager.GetString("ConfirmStripKeepOption", Labels.resourceCulture);
			}
		}
		public static string ConflictedFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("ConflictedFiles", Labels.resourceCulture);
			}
		}
		public static string ConnectRemoteServices
		{
			get
			{
				return Labels.ResourceManager.GetString("ConnectRemoteServices", Labels.resourceCulture);
			}
		}
		public static string ContentHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("ContentHeader", Labels.resourceCulture);
			}
		}
		public static string Context
		{
			get
			{
				return Labels.ResourceManager.GetString("Context", Labels.resourceCulture);
			}
		}
		public static string Context1
		{
			get
			{
				return Labels.ResourceManager.GetString("Context1", Labels.resourceCulture);
			}
		}
		public static string Context100
		{
			get
			{
				return Labels.ResourceManager.GetString("Context100", Labels.resourceCulture);
			}
		}
		public static string Context12
		{
			get
			{
				return Labels.ResourceManager.GetString("Context12", Labels.resourceCulture);
			}
		}
		public static string Context25
		{
			get
			{
				return Labels.ResourceManager.GetString("Context25", Labels.resourceCulture);
			}
		}
		public static string Context3
		{
			get
			{
				return Labels.ResourceManager.GetString("Context3", Labels.resourceCulture);
			}
		}
		public static string Context50
		{
			get
			{
				return Labels.ResourceManager.GetString("Context50", Labels.resourceCulture);
			}
		}
		public static string Context6
		{
			get
			{
				return Labels.ResourceManager.GetString("Context6", Labels.resourceCulture);
			}
		}
		public static string Continue
		{
			get
			{
				return Labels.ResourceManager.GetString("Continue", Labels.resourceCulture);
			}
		}
		public static string ContinueCommittingIfPendingChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("ContinueCommittingIfPendingChanges", Labels.resourceCulture);
			}
		}
		public static string ContinueGraftMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ContinueGraftMenu", Labels.resourceCulture);
			}
		}
		public static string ContinueRebaseMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ContinueRebaseMenu", Labels.resourceCulture);
			}
		}
		public static string ConvertFromSvnRevision
		{
			get
			{
				return Labels.ResourceManager.GetString("ConvertFromSvnRevision", Labels.resourceCulture);
			}
		}
		public static string CopyCloneUrlMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CopyCloneUrlMenu", Labels.resourceCulture);
			}
		}
		public static string CopyMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CopyMenu", Labels.resourceCulture);
			}
		}
		public static string CopyPathToClipboard
		{
			get
			{
				return Labels.ResourceManager.GetString("CopyPathToClipboard", Labels.resourceCulture);
			}
		}
		public static string CopyProjectUrlMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CopyProjectUrlMenu", Labels.resourceCulture);
			}
		}
		public static string Copyright
		{
			get
			{
				return Labels.ResourceManager.GetString("Copyright", Labels.resourceCulture);
			}
		}
		public static string CopySHAMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CopySHAMenu", Labels.resourceCulture);
			}
		}
		public static string CountryLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("CountryLabel", Labels.resourceCulture);
			}
		}
		public static string Create
		{
			get
			{
				return Labels.ResourceManager.GetString("Create", Labels.resourceCulture);
			}
		}
		public static string CreateBookmarksLeader
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateBookmarksLeader", Labels.resourceCulture);
			}
		}
		public static string CreateBookmarksTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateBookmarksTitle", Labels.resourceCulture);
			}
		}
		public static string CreateBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateBranch", Labels.resourceCulture);
			}
		}
		public static string CreateImportSSHKeyMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateImportSSHKeyMenu", Labels.resourceCulture);
			}
		}
		public static string CreateInFolder
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateInFolder", Labels.resourceCulture);
			}
		}
		public static string CreateLocalBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateLocalBranch", Labels.resourceCulture);
			}
		}
		public static string CreateNewCommitEvenIfFastForward
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateNewCommitEvenIfFastForward", Labels.resourceCulture);
			}
		}
		public static string CreateNewRepository
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateNewRepository", Labels.resourceCulture);
			}
		}
		public static string CreatePatch
		{
			get
			{
				return Labels.ResourceManager.GetString("CreatePatch", Labels.resourceCulture);
			}
		}
		public static string CreatePatchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CreatePatchMenu", Labels.resourceCulture);
			}
		}
		public static string CreatePullRequest
		{
			get
			{
				return Labels.ResourceManager.GetString("CreatePullRequest", Labels.resourceCulture);
			}
		}
		public static string CreatePullRequestDescNotPushing
		{
			get
			{
				return Labels.ResourceManager.GetString("CreatePullRequestDescNotPushing", Labels.resourceCulture);
			}
		}
		public static string CreatePullRequestDescPushing
		{
			get
			{
				return Labels.ResourceManager.GetString("CreatePullRequestDescPushing", Labels.resourceCulture);
			}
		}
		public static string CreatePullRequestMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CreatePullRequestMenu", Labels.resourceCulture);
			}
		}
		public static string CreatePullRequestOnWeb
		{
			get
			{
				return Labels.ResourceManager.GetString("CreatePullRequestOnWeb", Labels.resourceCulture);
			}
		}
		public static string CreateRepoInProgress
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateRepoInProgress", Labels.resourceCulture);
			}
		}
		public static string CreateRepository
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateRepository", Labels.resourceCulture);
			}
		}
		public static string CreateRepositoryOnAccountLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateRepositoryOnAccountLabel", Labels.resourceCulture);
			}
		}
		public static string CreateShelfMsg
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateShelfMsg", Labels.resourceCulture);
			}
		}
		public static string CreateShelfTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateShelfTitle", Labels.resourceCulture);
			}
		}
		public static string CreateStashMsg
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateStashMsg", Labels.resourceCulture);
			}
		}
		public static string CreateStashTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateStashTitle", Labels.resourceCulture);
			}
		}
		public static string CreateSvnBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("CreateSvnBranch", Labels.resourceCulture);
			}
		}
		public static string CreatingAccount
		{
			get
			{
				return Labels.ResourceManager.GetString("CreatingAccount", Labels.resourceCulture);
			}
		}
		public static string Current
		{
			get
			{
				return Labels.ResourceManager.GetString("Current", Labels.resourceCulture);
			}
		}
		public static string CurrentBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("CurrentBranch", Labels.resourceCulture);
			}
		}
		public static string CurrentBranchLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("CurrentBranchLabel", Labels.resourceCulture);
			}
		}
		public static string CurrentVersion
		{
			get
			{
				return Labels.ResourceManager.GetString("CurrentVersion", Labels.resourceCulture);
			}
		}
		public static string Custom
		{
			get
			{
				return Labels.ResourceManager.GetString("Custom", Labels.resourceCulture);
			}
		}
		public static string CustomActions
		{
			get
			{
				return Labels.ResourceManager.GetString("CustomActions", Labels.resourceCulture);
			}
		}
		public static string CustomActionsMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CustomActionsMenu", Labels.resourceCulture);
			}
		}
		public static string CustomActionsWindowFooter
		{
			get
			{
				return Labels.ResourceManager.GetString("CustomActionsWindowFooter", Labels.resourceCulture);
			}
		}
		public static string CutMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("CutMenu", Labels.resourceCulture);
			}
		}
		public static string DateHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("DateHeader", Labels.resourceCulture);
			}
		}
		public static string DateOrder
		{
			get
			{
				return Labels.ResourceManager.GetString("DateOrder", Labels.resourceCulture);
			}
		}
		public static string DefaultEncoding
		{
			get
			{
				return Labels.ResourceManager.GetString("DefaultEncoding", Labels.resourceCulture);
			}
		}
		public static string DefaultEncodingToolTip
		{
			get
			{
				return Labels.ResourceManager.GetString("DefaultEncodingToolTip", Labels.resourceCulture);
			}
		}
		public static string DefaultRemote
		{
			get
			{
				return Labels.ResourceManager.GetString("DefaultRemote", Labels.resourceCulture);
			}
		}
		public static string DefaultSSHKey
		{
			get
			{
				return Labels.ResourceManager.GetString("DefaultSSHKey", Labels.resourceCulture);
			}
		}
		public static string DefaultUserInfo
		{
			get
			{
				return Labels.ResourceManager.GetString("DefaultUserInfo", Labels.resourceCulture);
			}
		}
		public static string DefaultUserNameDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("DefaultUserNameDesc", Labels.resourceCulture);
			}
		}
		public static string DefaultUserNames
		{
			get
			{
				return Labels.ResourceManager.GetString("DefaultUserNames", Labels.resourceCulture);
			}
		}
		public static string Delete
		{
			get
			{
				return Labels.ResourceManager.GetString("Delete", Labels.resourceCulture);
			}
		}
		public static string DeleteBranches
		{
			get
			{
				return Labels.ResourceManager.GetString("DeleteBranches", Labels.resourceCulture);
			}
		}
		public static string DeleteCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("DeleteCommit", Labels.resourceCulture);
			}
		}
		public static string DescriptionHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("DescriptionHeader", Labels.resourceCulture);
			}
		}
		public static string DescriptionLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("DescriptionLabel", Labels.resourceCulture);
			}
		}
		public static string DestinationPath
		{
			get
			{
				return Labels.ResourceManager.GetString("DestinationPath", Labels.resourceCulture);
			}
		}
		public static string DetailsMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("DetailsMenu", Labels.resourceCulture);
			}
		}
		public static string DetectRenameSimilarity
		{
			get
			{
				return Labels.ResourceManager.GetString("DetectRenameSimilarity", Labels.resourceCulture);
			}
		}
		public static string DevelopmentBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("DevelopmentBranch", Labels.resourceCulture);
			}
		}
		public static string Diff
		{
			get
			{
				return Labels.ResourceManager.GetString("Diff", Labels.resourceCulture);
			}
		}
		public static string DiffAgainstCurrent
		{
			get
			{
				return Labels.ResourceManager.GetString("DiffAgainstCurrent", Labels.resourceCulture);
			}
		}
		public static string DiffColours
		{
			get
			{
				return Labels.ResourceManager.GetString("DiffColours", Labels.resourceCulture);
			}
		}
		public static string DiffCommand
		{
			get
			{
				return Labels.ResourceManager.GetString("DiffCommand", Labels.resourceCulture);
			}
		}
		public static string DiffConvertTabsToSpaces
		{
			get
			{
				return Labels.ResourceManager.GetString("DiffConvertTabsToSpaces", Labels.resourceCulture);
			}
		}
		public static string DiffParamLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("DiffParamLabel", Labels.resourceCulture);
			}
		}
		public static string DiffSystemDefault
		{
			get
			{
				return Labels.ResourceManager.GetString("DiffSystemDefault", Labels.resourceCulture);
			}
		}
		public static string DiffViewFont
		{
			get
			{
				return Labels.ResourceManager.GetString("DiffViewFont", Labels.resourceCulture);
			}
		}
		public static string DiffVsLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("DiffVsLabel", Labels.resourceCulture);
			}
		}
		public static string DiffVsMerged
		{
			get
			{
				return Labels.ResourceManager.GetString("DiffVsMerged", Labels.resourceCulture);
			}
		}
		public static string DiffVsParent
		{
			get
			{
				return Labels.ResourceManager.GetString("DiffVsParent", Labels.resourceCulture);
			}
		}
		public static string DisableSSLCertValidation
		{
			get
			{
				return Labels.ResourceManager.GetString("DisableSSLCertValidation", Labels.resourceCulture);
			}
		}
		public static string Discard
		{
			get
			{
				return Labels.ResourceManager.GetString("Discard", Labels.resourceCulture);
			}
		}
		public static string DiscardChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("DiscardChanges", Labels.resourceCulture);
			}
		}
		public static string DiscardFile
		{
			get
			{
				return Labels.ResourceManager.GetString("DiscardFile", Labels.resourceCulture);
			}
		}
		public static string DiscardFileChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("DiscardFileChanges", Labels.resourceCulture);
			}
		}
		public static string DiscardHunk
		{
			get
			{
				return Labels.ResourceManager.GetString("DiscardHunk", Labels.resourceCulture);
			}
		}
		public static string DiscardLines
		{
			get
			{
				return Labels.ResourceManager.GetString("DiscardLines", Labels.resourceCulture);
			}
		}
		public static string DiscardMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("DiscardMenu", Labels.resourceCulture);
			}
		}
		public static string DiscardSelectedMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("DiscardSelectedMenu", Labels.resourceCulture);
			}
		}
		public static string DisplayAuthorDateInLog
		{
			get
			{
				return Labels.ResourceManager.GetString("DisplayAuthorDateInLog", Labels.resourceCulture);
			}
		}
		public static string DisplayColumnGuideAt
		{
			get
			{
				return Labels.ResourceManager.GetString("DisplayColumnGuideAt", Labels.resourceCulture);
			}
		}
		public static string DoNotFastForward
		{
			get
			{
				return Labels.ResourceManager.GetString("DoNotFastForward", Labels.resourceCulture);
			}
		}
		public static string DoNothing
		{
			get
			{
				return Labels.ResourceManager.GetString("DoNothing", Labels.resourceCulture);
			}
		}
		public static string DownArrow
		{
			get
			{
				return Labels.ResourceManager.GetString("DownArrow", Labels.resourceCulture);
			}
		}
		public static string DownloadingGit
		{
			get
			{
				return Labels.ResourceManager.GetString("DownloadingGit", Labels.resourceCulture);
			}
		}
		public static string DownloadingLicense
		{
			get
			{
				return Labels.ResourceManager.GetString("DownloadingLicense", Labels.resourceCulture);
			}
		}
		public static string DownloadingMercurial
		{
			get
			{
				return Labels.ResourceManager.GetString("DownloadingMercurial", Labels.resourceCulture);
			}
		}
		public static string DownloadingVersionControl
		{
			get
			{
				return Labels.ResourceManager.GetString("DownloadingVersionControl", Labels.resourceCulture);
			}
		}
		public static string DraftCommitMessageMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("DraftCommitMessageMenu", Labels.resourceCulture);
			}
		}
		public static string DryRun
		{
			get
			{
				return Labels.ResourceManager.GetString("DryRun", Labels.resourceCulture);
			}
		}
		public static string Edit
		{
			get
			{
				return Labels.ResourceManager.GetString("Edit", Labels.resourceCulture);
			}
		}
		public static string EditConfigFile
		{
			get
			{
				return Labels.ResourceManager.GetString("EditConfigFile", Labels.resourceCulture);
			}
		}
		public static string EditCustomActionTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("EditCustomActionTitle", Labels.resourceCulture);
			}
		}
		public static string EditDefaultUsername
		{
			get
			{
				return Labels.ResourceManager.GetString("EditDefaultUsername", Labels.resourceCulture);
			}
		}
		public static string EditDefaultUsernameHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("EditDefaultUsernameHeader", Labels.resourceCulture);
			}
		}
		public static string EditFile
		{
			get
			{
				return Labels.ResourceManager.GetString("EditFile", Labels.resourceCulture);
			}
		}
		public static string EditMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("EditMenu", Labels.resourceCulture);
			}
		}
		public static string EditMessage
		{
			get
			{
				return Labels.ResourceManager.GetString("EditMessage", Labels.resourceCulture);
			}
		}
		public static string EditPassword
		{
			get
			{
				return Labels.ResourceManager.GetString("EditPassword", Labels.resourceCulture);
			}
		}
		public static string EditPasswordHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("EditPasswordHeader", Labels.resourceCulture);
			}
		}
		public static string EditSubtreeTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("EditSubtreeTitle", Labels.resourceCulture);
			}
		}
		public static string EmailAddress
		{
			get
			{
				return Labels.ResourceManager.GetString("EmailAddress", Labels.resourceCulture);
			}
		}
		public static string EmailLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("EmailLabel", Labels.resourceCulture);
			}
		}
		public static string EmbeddedGit
		{
			get
			{
				return Labels.ResourceManager.GetString("EmbeddedGit", Labels.resourceCulture);
			}
		}
		public static string EmbeddedHg
		{
			get
			{
				return Labels.ResourceManager.GetString("EmbeddedHg", Labels.resourceCulture);
			}
		}
		public static string Enable
		{
			get
			{
				return Labels.ResourceManager.GetString("Enable", Labels.resourceCulture);
			}
		}
		public static string EnableAnalytics
		{
			get
			{
				return Labels.ResourceManager.GetString("EnableAnalytics", Labels.resourceCulture);
			}
		}
		public static string EnableGitSupport
		{
			get
			{
				return Labels.ResourceManager.GetString("EnableGitSupport", Labels.resourceCulture);
			}
		}
		public static string EnableGravatarLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("EnableGravatarLabel", Labels.resourceCulture);
			}
		}
		public static string EnableMercurialSupport
		{
			get
			{
				return Labels.ResourceManager.GetString("EnableMercurialSupport", Labels.resourceCulture);
			}
		}
		public static string EnableTreeViewFileListOption
		{
			get
			{
				return Labels.ResourceManager.GetString("EnableTreeViewFileListOption", Labels.resourceCulture);
			}
		}
		public static string ExistingClonesGroupDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("ExistingClonesGroupDesc", Labels.resourceCulture);
			}
		}
		public static string ExitSourceTree
		{
			get
			{
				return Labels.ResourceManager.GetString("ExitSourceTree", Labels.resourceCulture);
			}
		}
		public static string ExitSourceTreeMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ExitSourceTreeMenu", Labels.resourceCulture);
			}
		}
		public static string ExtDiffArgsCaption
		{
			get
			{
				return Labels.ResourceManager.GetString("ExtDiffArgsCaption", Labels.resourceCulture);
			}
		}
		public static string ExtendedIntegrationDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("ExtendedIntegrationDesc", Labels.resourceCulture);
			}
		}
		public static string ExtensionName
		{
			get
			{
				return Labels.ResourceManager.GetString("ExtensionName", Labels.resourceCulture);
			}
		}
		public static string Extensions
		{
			get
			{
				return Labels.ResourceManager.GetString("Extensions", Labels.resourceCulture);
			}
		}
		public static string ExternalDiff
		{
			get
			{
				return Labels.ResourceManager.GetString("ExternalDiff", Labels.resourceCulture);
			}
		}
		public static string ExternalDiffMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ExternalDiffMenu", Labels.resourceCulture);
			}
		}
		public static string ExternalDiffMerge
		{
			get
			{
				return Labels.ResourceManager.GetString("ExternalDiffMerge", Labels.resourceCulture);
			}
		}
		public static string ExternalDiffTool
		{
			get
			{
				return Labels.ResourceManager.GetString("ExternalDiffTool", Labels.resourceCulture);
			}
		}
		public static string ExternalMergeMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ExternalMergeMenu", Labels.resourceCulture);
			}
		}
		public static string ExternalMergeTool
		{
			get
			{
				return Labels.ResourceManager.GetString("ExternalMergeTool", Labels.resourceCulture);
			}
		}
		public static string FAQMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("FAQMenu", Labels.resourceCulture);
			}
		}
		public static string FeatureBranchPrefix
		{
			get
			{
				return Labels.ResourceManager.GetString("FeatureBranchPrefix", Labels.resourceCulture);
			}
		}
		public static string Fetch
		{
			get
			{
				return Labels.ResourceManager.GetString("Fetch", Labels.resourceCulture);
			}
		}
		public static string FetchFromAllRemotes
		{
			get
			{
				return Labels.ResourceManager.GetString("FetchFromAllRemotes", Labels.resourceCulture);
			}
		}
		public static string FetchFromRemote
		{
			get
			{
				return Labels.ResourceManager.GetString("FetchFromRemote", Labels.resourceCulture);
			}
		}
		public static string FetchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("FetchMenu", Labels.resourceCulture);
			}
		}
		public static string FetchTags
		{
			get
			{
				return Labels.ResourceManager.GetString("FetchTags", Labels.resourceCulture);
			}
		}
		public static string FileLogTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("FileLogTitle", Labels.resourceCulture);
			}
		}
		public static string FileMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("FileMenu", Labels.resourceCulture);
			}
		}
		public static string Filename
		{
			get
			{
				return Labels.ResourceManager.GetString("Filename", Labels.resourceCulture);
			}
		}
		public static string FilenameLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("FilenameLabel", Labels.resourceCulture);
			}
		}
		public static string Files
		{
			get
			{
				return Labels.ResourceManager.GetString("Files", Labels.resourceCulture);
			}
		}
		public static string FileStatusViewMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("FileStatusViewMenu", Labels.resourceCulture);
			}
		}
		public static string FileStatusViewTab
		{
			get
			{
				return Labels.ResourceManager.GetString("FileStatusViewTab", Labels.resourceCulture);
			}
		}
		public static string Filter
		{
			get
			{
				return Labels.ResourceManager.GetString("Filter", Labels.resourceCulture);
			}
		}
		public static string FilterLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("FilterLabel", Labels.resourceCulture);
			}
		}
		public static string Finish
		{
			get
			{
				return Labels.ResourceManager.GetString("Finish", Labels.resourceCulture);
			}
		}
		public static string FirstNameLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("FirstNameLabel", Labels.resourceCulture);
			}
		}
		public static string FlatListMultiple
		{
			get
			{
				return Labels.ResourceManager.GetString("FlatListMultiple", Labels.resourceCulture);
			}
		}
		public static string FlatListSingle
		{
			get
			{
				return Labels.ResourceManager.GetString("FlatListSingle", Labels.resourceCulture);
			}
		}
		public static string FlowAfterFinishing
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowAfterFinishing", Labels.resourceCulture);
			}
		}
		public static string FlowBaseCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowBaseCommit", Labels.resourceCulture);
			}
		}
		public static string FlowChooseNextAction
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowChooseNextAction", Labels.resourceCulture);
			}
		}
		public static string FlowCreateNewBranchLogDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowCreateNewBranchLogDesc", Labels.resourceCulture);
			}
		}
		public static string FlowCurrentState
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowCurrentState", Labels.resourceCulture);
			}
		}
		public static string FlowCurrentStateFeatureDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowCurrentStateFeatureDesc", Labels.resourceCulture);
			}
		}
		public static string FlowCurrentStateHotfixDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowCurrentStateHotfixDesc", Labels.resourceCulture);
			}
		}
		public static string FlowCurrentStateReleaseDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowCurrentStateReleaseDesc", Labels.resourceCulture);
			}
		}
		public static string FlowDeleteBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowDeleteBranch", Labels.resourceCulture);
			}
		}
		public static string FlowFeatureBranchLogDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowFeatureBranchLogDesc", Labels.resourceCulture);
			}
		}
		public static string FlowFeatureName
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowFeatureName", Labels.resourceCulture);
			}
		}
		public static string FlowFinishFeature
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowFinishFeature", Labels.resourceCulture);
			}
		}
		public static string FlowFinishHotfix
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowFinishHotfix", Labels.resourceCulture);
			}
		}
		public static string FlowFinishRelease
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowFinishRelease", Labels.resourceCulture);
			}
		}
		public static string FlowHotfixBranchLogDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowHotfixBranchLogDesc", Labels.resourceCulture);
			}
		}
		public static string FlowHotfixName
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowHotfixName", Labels.resourceCulture);
			}
		}
		public static string FlowInitBranchBoxTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowInitBranchBoxTitle", Labels.resourceCulture);
			}
		}
		public static string FlowInitialiseRepo
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowInitialiseRepo", Labels.resourceCulture);
			}
		}
		public static string FlowInitPrefixBoxTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowInitPrefixBoxTitle", Labels.resourceCulture);
			}
		}
		public static string FlowLatestDevelopBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowLatestDevelopBranch", Labels.resourceCulture);
			}
		}
		public static string FlowLatestMasterBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowLatestMasterBranch", Labels.resourceCulture);
			}
		}
		public static string FlowMergeXintoY
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowMergeXintoY", Labels.resourceCulture);
			}
		}
		public static string FlowNextAction
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowNextAction", Labels.resourceCulture);
			}
		}
		public static string FlowOtherAction
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowOtherAction", Labels.resourceCulture);
			}
		}
		public static string FlowPushChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowPushChanges", Labels.resourceCulture);
			}
		}
		public static string FlowRebaseOnDevelopmentBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowRebaseOnDevelopmentBranch", Labels.resourceCulture);
			}
		}
		public static string FlowRecommendedActions
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowRecommendedActions", Labels.resourceCulture);
			}
		}
		public static string FlowReleaseBranchLogDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowReleaseBranchLogDesc", Labels.resourceCulture);
			}
		}
		public static string FlowReleaseName
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowReleaseName", Labels.resourceCulture);
			}
		}
		public static string FlowStartFeature
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowStartFeature", Labels.resourceCulture);
			}
		}
		public static string FlowStartHotfix
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowStartHotfix", Labels.resourceCulture);
			}
		}
		public static string FlowStartRelease
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowStartRelease", Labels.resourceCulture);
			}
		}
		public static string FlowTagOptionDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("FlowTagOptionDesc", Labels.resourceCulture);
			}
		}
		public static string FluidStaging
		{
			get
			{
				return Labels.ResourceManager.GetString("FluidStaging", Labels.resourceCulture);
			}
		}
		public static string FolderPrefixLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("FolderPrefixLabel", Labels.resourceCulture);
			}
		}
		public static string FollowRenamedFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("FollowRenamedFiles", Labels.resourceCulture);
			}
		}
		public static string FontFamily
		{
			get
			{
				return Labels.ResourceManager.GetString("FontFamily", Labels.resourceCulture);
			}
		}
		public static string FontSampleText
		{
			get
			{
				return Labels.ResourceManager.GetString("FontSampleText", Labels.resourceCulture);
			}
		}
		public static string FontSampleTextContents
		{
			get
			{
				return Labels.ResourceManager.GetString("FontSampleTextContents", Labels.resourceCulture);
			}
		}
		public static string FontStyleWeightStretch
		{
			get
			{
				return Labels.ResourceManager.GetString("FontStyleWeightStretch", Labels.resourceCulture);
			}
		}
		public static string ForceDelete
		{
			get
			{
				return Labels.ResourceManager.GetString("ForceDelete", Labels.resourceCulture);
			}
		}
		public static string ForceDeleteRegardlessOfMergeStatus
		{
			get
			{
				return Labels.ResourceManager.GetString("ForceDeleteRegardlessOfMergeStatus", Labels.resourceCulture);
			}
		}
		public static string ForgotYourPassword
		{
			get
			{
				return Labels.ResourceManager.GetString("ForgotYourPassword", Labels.resourceCulture);
			}
		}
		public static string FreeClientInfo
		{
			get
			{
				return Labels.ResourceManager.GetString("FreeClientInfo", Labels.resourceCulture);
			}
		}
		public static string FromLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("FromLabel", Labels.resourceCulture);
			}
		}
		public static string FullName
		{
			get
			{
				return Labels.ResourceManager.GetString("FullName", Labels.resourceCulture);
			}
		}
		public static string General
		{
			get
			{
				return Labels.ResourceManager.GetString("General", Labels.resourceCulture);
			}
		}
		public static string GetWorkingCopy
		{
			get
			{
				return Labels.ResourceManager.GetString("GetWorkingCopy", Labels.resourceCulture);
			}
		}
		public static string GitAheadAnnotate
		{
			get
			{
				return Labels.ResourceManager.GetString("GitAheadAnnotate", Labels.resourceCulture);
			}
		}
		public static string GitBehindAnnotate
		{
			get
			{
				return Labels.ResourceManager.GetString("GitBehindAnnotate", Labels.resourceCulture);
			}
		}
		public static string GitDisabledText
		{
			get
			{
				return Labels.ResourceManager.GetString("GitDisabledText", Labels.resourceCulture);
			}
		}
		public static string GitFlow
		{
			get
			{
				return Labels.ResourceManager.GetString("GitFlow", Labels.resourceCulture);
			}
		}
		public static string GitFlowInitHeading
		{
			get
			{
				return Labels.ResourceManager.GetString("GitFlowInitHeading", Labels.resourceCulture);
			}
		}
		public static string GitFlowMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("GitFlowMenu", Labels.resourceCulture);
			}
		}
		public static string GitPushDefaultCurrentTip
		{
			get
			{
				return Labels.ResourceManager.GetString("GitPushDefaultCurrentTip", Labels.resourceCulture);
			}
		}
		public static string GitPushDefaultMatchingTip
		{
			get
			{
				return Labels.ResourceManager.GetString("GitPushDefaultMatchingTip", Labels.resourceCulture);
			}
		}
		public static string GitPushDefaultNothingTip
		{
			get
			{
				return Labels.ResourceManager.GetString("GitPushDefaultNothingTip", Labels.resourceCulture);
			}
		}
		public static string GitPushDefaultSimpleTip
		{
			get
			{
				return Labels.ResourceManager.GetString("GitPushDefaultSimpleTip", Labels.resourceCulture);
			}
		}
		public static string GitPushDefaultUpstreamTip
		{
			get
			{
				return Labels.ResourceManager.GetString("GitPushDefaultUpstreamTip", Labels.resourceCulture);
			}
		}
		public static string GitResetConfirmTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("GitResetConfirmTitle", Labels.resourceCulture);
			}
		}
		public static string GitVersion
		{
			get
			{
				return Labels.ResourceManager.GetString("GitVersion", Labels.resourceCulture);
			}
		}
		public static string GlobalIgnoreList
		{
			get
			{
				return Labels.ResourceManager.GetString("GlobalIgnoreList", Labels.resourceCulture);
			}
		}
		public static string GraftMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("GraftMenu", Labels.resourceCulture);
			}
		}
		public static string GraphHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("GraphHeader", Labels.resourceCulture);
			}
		}
		public static string HelpImproveSourceTreeLinkText
		{
			get
			{
				return Labels.ResourceManager.GetString("HelpImproveSourceTreeLinkText", Labels.resourceCulture);
			}
		}
		public static string HelpImproveSourceTreePreText
		{
			get
			{
				return Labels.ResourceManager.GetString("HelpImproveSourceTreePreText", Labels.resourceCulture);
			}
		}
		public static string HelpMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("HelpMenu", Labels.resourceCulture);
			}
		}
		public static string HelpTranslateSourceTree
		{
			get
			{
				return Labels.ResourceManager.GetString("HelpTranslateSourceTree", Labels.resourceCulture);
			}
		}
		public static string HgDisabledText
		{
			get
			{
				return Labels.ResourceManager.GetString("HgDisabledText", Labels.resourceCulture);
			}
		}
		public static string HgDisplayMultipleHeads
		{
			get
			{
				return Labels.ResourceManager.GetString("HgDisplayMultipleHeads", Labels.resourceCulture);
			}
		}
		public static string HgDownloadingChangesetsPleaseWait
		{
			get
			{
				return Labels.ResourceManager.GetString("HgDownloadingChangesetsPleaseWait", Labels.resourceCulture);
			}
		}
		public static string HgExtCore
		{
			get
			{
				return Labels.ResourceManager.GetString("HgExtCore", Labels.resourceCulture);
			}
		}
		public static string HgExtensionNotes
		{
			get
			{
				return Labels.ResourceManager.GetString("HgExtensionNotes", Labels.resourceCulture);
			}
		}
		public static string HgExtInternal
		{
			get
			{
				return Labels.ResourceManager.GetString("HgExtInternal", Labels.resourceCulture);
			}
		}
		public static string HgFlow
		{
			get
			{
				return Labels.ResourceManager.GetString("HgFlow", Labels.resourceCulture);
			}
		}
		public static string HgFlowInitHeading
		{
			get
			{
				return Labels.ResourceManager.GetString("HgFlowInitHeading", Labels.resourceCulture);
			}
		}
		public static string HgPullCountCurrentBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("HgPullCountCurrentBranch", Labels.resourceCulture);
			}
		}
		public static string HgUseGraft
		{
			get
			{
				return Labels.ResourceManager.GetString("HgUseGraft", Labels.resourceCulture);
			}
		}
		public static string HgVersion
		{
			get
			{
				return Labels.ResourceManager.GetString("HgVersion", Labels.resourceCulture);
			}
		}
		public static string HomePageLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("HomePageLabel", Labels.resourceCulture);
			}
		}
		public static string Host
		{
			get
			{
				return Labels.ResourceManager.GetString("Host", Labels.resourceCulture);
			}
		}
		public static string HostAccountBadURLMsg
		{
			get
			{
				return Labels.ResourceManager.GetString("HostAccountBadURLMsg", Labels.resourceCulture);
			}
		}
		public static string HostAccountBadURLTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("HostAccountBadURLTitle", Labels.resourceCulture);
			}
		}
		public static string HostBitbucketName
		{
			get
			{
				return Labels.ResourceManager.GetString("HostBitbucketName", Labels.resourceCulture);
			}
		}
		public static string HostedAccountList
		{
			get
			{
				return Labels.ResourceManager.GetString("HostedAccountList", Labels.resourceCulture);
			}
		}
		public static string HostedAccountTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("HostedAccountTitle", Labels.resourceCulture);
			}
		}
		public static string HostedCreateRepo
		{
			get
			{
				return Labels.ResourceManager.GetString("HostedCreateRepo", Labels.resourceCulture);
			}
		}
		public static string HostedEditAccounts
		{
			get
			{
				return Labels.ResourceManager.GetString("HostedEditAccounts", Labels.resourceCulture);
			}
		}
		public static string HostedFilterAllRepos
		{
			get
			{
				return Labels.ResourceManager.GetString("HostedFilterAllRepos", Labels.resourceCulture);
			}
		}
		public static string HostedFilterOwnAndFollowed
		{
			get
			{
				return Labels.ResourceManager.GetString("HostedFilterOwnAndFollowed", Labels.resourceCulture);
			}
		}
		public static string HostedProjectsTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("HostedProjectsTitle", Labels.resourceCulture);
			}
		}
		public static string HostGitHubName
		{
			get
			{
				return Labels.ResourceManager.GetString("HostGitHubName", Labels.resourceCulture);
			}
		}
		public static string HostingServiceLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("HostingServiceLabel", Labels.resourceCulture);
			}
		}
		public static string HostRootUrlLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("HostRootUrlLabel", Labels.resourceCulture);
			}
		}
		public static string HostStashName
		{
			get
			{
				return Labels.ResourceManager.GetString("HostStashName", Labels.resourceCulture);
			}
		}
		public static string HostTypeLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("HostTypeLabel", Labels.resourceCulture);
			}
		}
		public static string HostURLLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("HostURLLabel", Labels.resourceCulture);
			}
		}
		public static string HotfixBranchPrefix
		{
			get
			{
				return Labels.ResourceManager.GetString("HotfixBranchPrefix", Labels.resourceCulture);
			}
		}
		public static string Ignore
		{
			get
			{
				return Labels.ResourceManager.GetString("Ignore", Labels.resourceCulture);
			}
		}
		public static string IgnoreAllFilesWithThisExtension
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreAllFilesWithThisExtension", Labels.resourceCulture);
			}
		}
		public static string IgnoreCustomPattern
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreCustomPattern", Labels.resourceCulture);
			}
		}
		public static string IgnoredFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoredFiles", Labels.resourceCulture);
			}
		}
		public static string IgnoreEverythingBeneath
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreEverythingBeneath", Labels.resourceCulture);
			}
		}
		public static string IgnoreExactFilenames
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreExactFilenames", Labels.resourceCulture);
			}
		}
		public static string IgnoreFile
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreFile", Labels.resourceCulture);
			}
		}
		public static string IgnoreFilenamesOrPattern
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreFilenamesOrPattern", Labels.resourceCulture);
			}
		}
		public static string IgnoreFilePatterns
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreFilePatterns", Labels.resourceCulture);
			}
		}
		public static string IgnoreFor
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreFor", Labels.resourceCulture);
			}
		}
		public static string IgnoreForThisRepoOnly
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreForThisRepoOnly", Labels.resourceCulture);
			}
		}
		public static string IgnoreGlobal
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreGlobal", Labels.resourceCulture);
			}
		}
		public static string IgnoreMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreMenu", Labels.resourceCulture);
			}
		}
		public static string IgnoreWhitespace
		{
			get
			{
				return Labels.ResourceManager.GetString("IgnoreWhitespace", Labels.resourceCulture);
			}
		}
		public static string ImportFullCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("ImportFullCommit", Labels.resourceCulture);
			}
		}
		public static string ImportLicense
		{
			get
			{
				return Labels.ResourceManager.GetString("ImportLicense", Labels.resourceCulture);
			}
		}
		public static string IncludeLogMessagesInMergeCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("IncludeLogMessagesInMergeCommit", Labels.resourceCulture);
			}
		}
		public static string IncomingChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("IncomingChanges", Labels.resourceCulture);
			}
		}
		public static string InEnglishGB
		{
			get
			{
				return Labels.ResourceManager.GetString("InEnglishGB", Labels.resourceCulture);
			}
		}
		public static string InEnglishUS
		{
			get
			{
				return Labels.ResourceManager.GetString("InEnglishUS", Labels.resourceCulture);
			}
		}
		public static string InFrench
		{
			get
			{
				return Labels.ResourceManager.GetString("InFrench", Labels.resourceCulture);
			}
		}
		public static string InGerman
		{
			get
			{
				return Labels.ResourceManager.GetString("InGerman", Labels.resourceCulture);
			}
		}
		public static string InSpanish
		{
			get
			{
				return Labels.ResourceManager.GetString("InSpanish", Labels.resourceCulture);
			}
		}
		public static string InstallingGitFlow
		{
			get
			{
				return Labels.ResourceManager.GetString("InstallingGitFlow", Labels.resourceCulture);
			}
		}
		public static string InteractiveRebaseFromCommitProcessTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("InteractiveRebaseFromCommitProcessTitle", Labels.resourceCulture);
			}
		}
		public static string InteractiveRebaseMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("InteractiveRebaseMenu", Labels.resourceCulture);
			}
		}
		public static string InteractiveRebaseProcessTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("InteractiveRebaseProcessTitle", Labels.resourceCulture);
			}
		}
		public static string InternalDiffView
		{
			get
			{
				return Labels.ResourceManager.GetString("InternalDiffView", Labels.resourceCulture);
			}
		}
		public static string JumpTo
		{
			get
			{
				return Labels.ResourceManager.GetString("JumpTo", Labels.resourceCulture);
			}
		}
		public static string KeepBackupsOnRevert
		{
			get
			{
				return Labels.ResourceManager.GetString("KeepBackupsOnRevert", Labels.resourceCulture);
			}
		}
		public static string KeepStagedChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("KeepStagedChanges", Labels.resourceCulture);
			}
		}
		public static string LanguageLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("LanguageLabel", Labels.resourceCulture);
			}
		}
		public static string LastNameLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("LastNameLabel", Labels.resourceCulture);
			}
		}
		public static string LatestUpdates
		{
			get
			{
				return Labels.ResourceManager.GetString("LatestUpdates", Labels.resourceCulture);
			}
		}
		public static string LaunchSSHAgentMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("LaunchSSHAgentMenu", Labels.resourceCulture);
			}
		}
		public static string LicensesManagedBy
		{
			get
			{
				return Labels.ResourceManager.GetString("LicensesManagedBy", Labels.resourceCulture);
			}
		}
		public static string LightweightTag
		{
			get
			{
				return Labels.ResourceManager.GetString("LightweightTag", Labels.resourceCulture);
			}
		}
		public static string LineHeader
		{
			get
			{
				return Labels.ResourceManager.GetString("LineHeader", Labels.resourceCulture);
			}
		}
		public static string LinesOfContext
		{
			get
			{
				return Labels.ResourceManager.GetString("LinesOfContext", Labels.resourceCulture);
			}
		}
		public static string LinkToUrlLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("LinkToUrlLabel", Labels.resourceCulture);
			}
		}
		public static string Local
		{
			get
			{
				return Labels.ResourceManager.GetString("Local", Labels.resourceCulture);
			}
		}
		public static string LocalBranchColumn
		{
			get
			{
				return Labels.ResourceManager.GetString("LocalBranchColumn", Labels.resourceCulture);
			}
		}
		public static string LocalBranchLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("LocalBranchLabel", Labels.resourceCulture);
			}
		}
		public static string LocalBranchShouldTrack
		{
			get
			{
				return Labels.ResourceManager.GetString("LocalBranchShouldTrack", Labels.resourceCulture);
			}
		}
		public static string LocalRelativePathLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("LocalRelativePathLabel", Labels.resourceCulture);
			}
		}
		public static string LocalTag
		{
			get
			{
				return Labels.ResourceManager.GetString("LocalTag", Labels.resourceCulture);
			}
		}
		public static string Location
		{
			get
			{
				return Labels.ResourceManager.GetString("Location", Labels.resourceCulture);
			}
		}
		public static string LogDateTimeFormat
		{
			get
			{
				return Labels.ResourceManager.GetString("LogDateTimeFormat", Labels.resourceCulture);
			}
		}
		public static string LoggingIn
		{
			get
			{
				return Labels.ResourceManager.GetString("LoggingIn", Labels.resourceCulture);
			}
		}
		public static string LoginStatusLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("LoginStatusLabel", Labels.resourceCulture);
			}
		}
		public static string LogSelectedMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("LogSelectedMenu", Labels.resourceCulture);
			}
		}
		public static string LogViewMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("LogViewMenu", Labels.resourceCulture);
			}
		}
		public static string LogViewTab
		{
			get
			{
				return Labels.ResourceManager.GetString("LogViewTab", Labels.resourceCulture);
			}
		}
		public static string LostPassword
		{
			get
			{
				return Labels.ResourceManager.GetString("LostPassword", Labels.resourceCulture);
			}
		}
		public static string MarkResolvedMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("MarkResolvedMenu", Labels.resourceCulture);
			}
		}
		public static string MarkUnresolvedMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("MarkUnresolvedMenu", Labels.resourceCulture);
			}
		}
		public static string Matching
		{
			get
			{
				return Labels.ResourceManager.GetString("Matching", Labels.resourceCulture);
			}
		}
		public static string MaxDiffFilesLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("MaxDiffFilesLabel", Labels.resourceCulture);
			}
		}
		public static string MaxDiffLinesLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("MaxDiffLinesLabel", Labels.resourceCulture);
			}
		}
		public static string MenuCaption
		{
			get
			{
				return Labels.ResourceManager.GetString("MenuCaption", Labels.resourceCulture);
			}
		}
		public static string MenuCaptionLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("MenuCaptionLabel", Labels.resourceCulture);
			}
		}
		public static string Merge
		{
			get
			{
				return Labels.ResourceManager.GetString("Merge", Labels.resourceCulture);
			}
		}
		public static string MergeCommand
		{
			get
			{
				return Labels.ResourceManager.GetString("MergeCommand", Labels.resourceCulture);
			}
		}
		public static string MergeCommitPrefix
		{
			get
			{
				return Labels.ResourceManager.GetString("MergeCommitPrefix", Labels.resourceCulture);
			}
		}
		public static string MergeMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("MergeMenu", Labels.resourceCulture);
			}
		}
		public static string Message
		{
			get
			{
				return Labels.ResourceManager.GetString("Message", Labels.resourceCulture);
			}
		}
		public static string MessageLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("MessageLabel", Labels.resourceCulture);
			}
		}
		public static string Minutes
		{
			get
			{
				return Labels.ResourceManager.GetString("Minutes", Labels.resourceCulture);
			}
		}
		public static string Misc
		{
			get
			{
				return Labels.ResourceManager.GetString("Misc", Labels.resourceCulture);
			}
		}
		public static string Miscellaneous
		{
			get
			{
				return Labels.ResourceManager.GetString("Miscellaneous", Labels.resourceCulture);
			}
		}
		public static string ModeLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ModeLabel", Labels.resourceCulture);
			}
		}
		public static string ModifiedFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("ModifiedFiles", Labels.resourceCulture);
			}
		}
		public static string ModifyIndex
		{
			get
			{
				return Labels.ResourceManager.GetString("ModifyIndex", Labels.resourceCulture);
			}
		}
		public static string ModifyWorkingCopy
		{
			get
			{
				return Labels.ResourceManager.GetString("ModifyWorkingCopy", Labels.resourceCulture);
			}
		}
		public static string MoveExistingTag
		{
			get
			{
				return Labels.ResourceManager.GetString("MoveExistingTag", Labels.resourceCulture);
			}
		}
		public static string MoveMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("MoveMenu", Labels.resourceCulture);
			}
		}
		public static string MoveTag
		{
			get
			{
				return Labels.ResourceManager.GetString("MoveTag", Labels.resourceCulture);
			}
		}
		public static string Name
		{
			get
			{
				return Labels.ResourceManager.GetString("Name", Labels.resourceCulture);
			}
		}
		public static string NameLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("NameLabel", Labels.resourceCulture);
			}
		}
		public static string Network
		{
			get
			{
				return Labels.ResourceManager.GetString("Network", Labels.resourceCulture);
			}
		}
		public static string NewBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("NewBranch", Labels.resourceCulture);
			}
		}
		public static string NewBranchLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("NewBranchLabel", Labels.resourceCulture);
			}
		}
		public static string NewBranchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("NewBranchMenu", Labels.resourceCulture);
			}
		}
		public static string NewFolder
		{
			get
			{
				return Labels.ResourceManager.GetString("NewFolder", Labels.resourceCulture);
			}
		}
		public static string NewLocalBranchName
		{
			get
			{
				return Labels.ResourceManager.GetString("NewLocalBranchName", Labels.resourceCulture);
			}
		}
		public static string NewRemoteMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("NewRemoteMenu", Labels.resourceCulture);
			}
		}
		public static string NewRepository
		{
			get
			{
				return Labels.ResourceManager.GetString("NewRepository", Labels.resourceCulture);
			}
		}
		public static string NewSubmoduleMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("NewSubmoduleMenu", Labels.resourceCulture);
			}
		}
		public static string NewSubrepoMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("NewSubrepoMenu", Labels.resourceCulture);
			}
		}
		public static string NewTagMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("NewTagMenu", Labels.resourceCulture);
			}
		}
		public static string Next
		{
			get
			{
				return Labels.ResourceManager.GetString("Next", Labels.resourceCulture);
			}
		}
		public static string NextTabMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("NextTabMenu", Labels.resourceCulture);
			}
		}
		public static string NoChangesToPull
		{
			get
			{
				return Labels.ResourceManager.GetString("NoChangesToPull", Labels.resourceCulture);
			}
		}
		public static string NoChangesToPush
		{
			get
			{
				return Labels.ResourceManager.GetString("NoChangesToPush", Labels.resourceCulture);
			}
		}
		public static string NoHardlinks
		{
			get
			{
				return Labels.ResourceManager.GetString("NoHardlinks", Labels.resourceCulture);
			}
		}
		public static string None
		{
			get
			{
				return Labels.ResourceManager.GetString("None", Labels.resourceCulture);
			}
		}
		public static string NoStaging
		{
			get
			{
				return Labels.ResourceManager.GetString("NoStaging", Labels.resourceCulture);
			}
		}
		public static string NoSuggestions
		{
			get
			{
				return Labels.ResourceManager.GetString("NoSuggestions", Labels.resourceCulture);
			}
		}
		public static string Nothing
		{
			get
			{
				return Labels.ResourceManager.GetString("Nothing", Labels.resourceCulture);
			}
		}
		public static string NothingToCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("NothingToCommit", Labels.resourceCulture);
			}
		}
		public static string NumberFifty
		{
			get
			{
				return Labels.ResourceManager.GetString("NumberFifty", Labels.resourceCulture);
			}
		}
		public static string NumberOne
		{
			get
			{
				return Labels.ResourceManager.GetString("NumberOne", Labels.resourceCulture);
			}
		}
		public static string NumberOneHundred
		{
			get
			{
				return Labels.ResourceManager.GetString("NumberOneHundred", Labels.resourceCulture);
			}
		}
		public static string NumberSix
		{
			get
			{
				return Labels.ResourceManager.GetString("NumberSix", Labels.resourceCulture);
			}
		}
		public static string NumberThree
		{
			get
			{
				return Labels.ResourceManager.GetString("NumberThree", Labels.resourceCulture);
			}
		}
		public static string NumberTwelve
		{
			get
			{
				return Labels.ResourceManager.GetString("NumberTwelve", Labels.resourceCulture);
			}
		}
		public static string NumberTwentyFive
		{
			get
			{
				return Labels.ResourceManager.GetString("NumberTwentyFive", Labels.resourceCulture);
			}
		}
		public static string OfferToCreateBookmarks
		{
			get
			{
				return Labels.ResourceManager.GetString("OfferToCreateBookmarks", Labels.resourceCulture);
			}
		}
		public static string OK
		{
			get
			{
				return Labels.ResourceManager.GetString("OK", Labels.resourceCulture);
			}
		}
		public static string Open
		{
			get
			{
				return Labels.ResourceManager.GetString("Open", Labels.resourceCulture);
			}
		}
		public static string OpenAfter
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenAfter", Labels.resourceCulture);
			}
		}
		public static string OpenBefore
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenBefore", Labels.resourceCulture);
			}
		}
		public static string OpenCurrentVersion
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenCurrentVersion", Labels.resourceCulture);
			}
		}
		public static string OpenExisting
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenExisting", Labels.resourceCulture);
			}
		}
		public static string OpenFolderFilter
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenFolderFilter", Labels.resourceCulture);
			}
		}
		public static string OpenInBrowserMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenInBrowserMenu", Labels.resourceCulture);
			}
		}
		public static string OpenInExplorer
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenInExplorer", Labels.resourceCulture);
			}
		}
		public static string OpenInSeparateWindow
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenInSeparateWindow", Labels.resourceCulture);
			}
		}
		public static string OpenInTerminalMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenInTerminalMenu", Labels.resourceCulture);
			}
		}
		public static string OpenMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenMenu", Labels.resourceCulture);
			}
		}
		public static string OpenSelectedVersion
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenSelectedVersion", Labels.resourceCulture);
			}
		}
		public static string OpenSourceCredits
		{
			get
			{
				return Labels.ResourceManager.GetString("OpenSourceCredits", Labels.resourceCulture);
			}
		}
		public static string Optional
		{
			get
			{
				return Labels.ResourceManager.GetString("Optional", Labels.resourceCulture);
			}
		}
		public static string OptionalExtendedIntegration
		{
			get
			{
				return Labels.ResourceManager.GetString("OptionalExtendedIntegration", Labels.resourceCulture);
			}
		}
		public static string Options
		{
			get
			{
				return Labels.ResourceManager.GetString("Options", Labels.resourceCulture);
			}
		}
		public static string OptionsMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("OptionsMenu", Labels.resourceCulture);
			}
		}
		public static string OrSwitchToCloneNew
		{
			get
			{
				return Labels.ResourceManager.GetString("OrSwitchToCloneNew", Labels.resourceCulture);
			}
		}
		public static string Other
		{
			get
			{
				return Labels.ResourceManager.GetString("Other", Labels.resourceCulture);
			}
		}
		public static string OutgoingChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("OutgoingChanges", Labels.resourceCulture);
			}
		}
		public static string Owner
		{
			get
			{
				return Labels.ResourceManager.GetString("Owner", Labels.resourceCulture);
			}
		}
		public static string OwnerLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("OwnerLabel", Labels.resourceCulture);
			}
		}
		public static string Parameters
		{
			get
			{
				return Labels.ResourceManager.GetString("Parameters", Labels.resourceCulture);
			}
		}
		public static string ParametersLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ParametersLabel", Labels.resourceCulture);
			}
		}
		public static string Password
		{
			get
			{
				return Labels.ResourceManager.GetString("Password", Labels.resourceCulture);
			}
		}
		public static string PasswordEnterUsername
		{
			get
			{
				return Labels.ResourceManager.GetString("PasswordEnterUsername", Labels.resourceCulture);
			}
		}
		public static string PasswordIsSet
		{
			get
			{
				return Labels.ResourceManager.GetString("PasswordIsSet", Labels.resourceCulture);
			}
		}
		public static string PasswordLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("PasswordLabel", Labels.resourceCulture);
			}
		}
		public static string PasswordLoginFailed
		{
			get
			{
				return Labels.ResourceManager.GetString("PasswordLoginFailed", Labels.resourceCulture);
			}
		}
		public static string PasswordNotAuthenticating
		{
			get
			{
				return Labels.ResourceManager.GetString("PasswordNotAuthenticating", Labels.resourceCulture);
			}
		}
		public static string PasswordNotSet
		{
			get
			{
				return Labels.ResourceManager.GetString("PasswordNotSet", Labels.resourceCulture);
			}
		}
		public static string PasteMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("PasteMenu", Labels.resourceCulture);
			}
		}
		public static string PatchCreateFilePerCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("PatchCreateFilePerCommit", Labels.resourceCulture);
			}
		}
		public static string PatchFileLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("PatchFileLabel", Labels.resourceCulture);
			}
		}
		public static string Path
		{
			get
			{
				return Labels.ResourceManager.GetString("Path", Labels.resourceCulture);
			}
		}
		public static string PendingFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("PendingFiles", Labels.resourceCulture);
			}
		}
		public static string PickACommitToMerge
		{
			get
			{
				return Labels.ResourceManager.GetString("PickACommitToMerge", Labels.resourceCulture);
			}
		}
		public static string PickAnother
		{
			get
			{
				return Labels.ResourceManager.GetString("PickAnother", Labels.resourceCulture);
			}
		}
		public static string PickCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("PickCommit", Labels.resourceCulture);
			}
		}
		public static string PleaseEnterRegistrationDetails
		{
			get
			{
				return Labels.ResourceManager.GetString("PleaseEnterRegistrationDetails", Labels.resourceCulture);
			}
		}
		public static string PleaseEnterYourEmail
		{
			get
			{
				return Labels.ResourceManager.GetString("PleaseEnterYourEmail", Labels.resourceCulture);
			}
		}
		public static string PleaseLogInToYourAccount
		{
			get
			{
				return Labels.ResourceManager.GetString("PleaseLogInToYourAccount", Labels.resourceCulture);
			}
		}
		public static string PortLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("PortLabel", Labels.resourceCulture);
			}
		}
		public static string PreferredProtocolLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("PreferredProtocolLabel", Labels.resourceCulture);
			}
		}
		public static string Preview
		{
			get
			{
				return Labels.ResourceManager.GetString("Preview", Labels.resourceCulture);
			}
		}
		public static string Previous
		{
			get
			{
				return Labels.ResourceManager.GetString("Previous", Labels.resourceCulture);
			}
		}
		public static string PrevTabMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("PrevTabMenu", Labels.resourceCulture);
			}
		}
		public static string PrivacyPolicy
		{
			get
			{
				return Labels.ResourceManager.GetString("PrivacyPolicy", Labels.resourceCulture);
			}
		}
		public static string ProceedNotRecommended
		{
			get
			{
				return Labels.ResourceManager.GetString("ProceedNotRecommended", Labels.resourceCulture);
			}
		}
		public static string ProductionBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("ProductionBranch", Labels.resourceCulture);
			}
		}
		public static string ProjectFolder
		{
			get
			{
				return Labels.ResourceManager.GetString("ProjectFolder", Labels.resourceCulture);
			}
		}
		public static string ProjectLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ProjectLabel", Labels.resourceCulture);
			}
		}
		public static string ProjectPrefixLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ProjectPrefixLabel", Labels.resourceCulture);
			}
		}
		public static string ProjectsToDisplayRepositoriesFor
		{
			get
			{
				return Labels.ResourceManager.GetString("ProjectsToDisplayRepositoriesFor", Labels.resourceCulture);
			}
		}
		public static string ProjectsToInclude
		{
			get
			{
				return Labels.ResourceManager.GetString("ProjectsToInclude", Labels.resourceCulture);
			}
		}
		public static string Protocol
		{
			get
			{
				return Labels.ResourceManager.GetString("Protocol", Labels.resourceCulture);
			}
		}
		public static string ProxyEnableBasicAuthentication
		{
			get
			{
				return Labels.ResourceManager.GetString("ProxyEnableBasicAuthentication", Labels.resourceCulture);
			}
		}
		public static string ProxyFooterNote
		{
			get
			{
				return Labels.ResourceManager.GetString("ProxyFooterNote", Labels.resourceCulture);
			}
		}
		public static string ProxyServerEnabled
		{
			get
			{
				return Labels.ResourceManager.GetString("ProxyServerEnabled", Labels.resourceCulture);
			}
		}
		public static string ProxyServerHostName
		{
			get
			{
				return Labels.ResourceManager.GetString("ProxyServerHostName", Labels.resourceCulture);
			}
		}
		public static string ProxyServerSettings
		{
			get
			{
				return Labels.ResourceManager.GetString("ProxyServerSettings", Labels.resourceCulture);
			}
		}
		public static string ProxyUseBasicAuth
		{
			get
			{
				return Labels.ResourceManager.GetString("ProxyUseBasicAuth", Labels.resourceCulture);
			}
		}
		public static string ProxyUseCustomSettings
		{
			get
			{
				return Labels.ResourceManager.GetString("ProxyUseCustomSettings", Labels.resourceCulture);
			}
		}
		public static string ProxyUseOSSettings
		{
			get
			{
				return Labels.ResourceManager.GetString("ProxyUseOSSettings", Labels.resourceCulture);
			}
		}
		public static string PruneTracking
		{
			get
			{
				return Labels.ResourceManager.GetString("PruneTracking", Labels.resourceCulture);
			}
		}
		public static string PubliclyVisible
		{
			get
			{
				return Labels.ResourceManager.GetString("PubliclyVisible", Labels.resourceCulture);
			}
		}
		public static string Pull
		{
			get
			{
				return Labels.ResourceManager.GetString("Pull", Labels.resourceCulture);
			}
		}
		public static string PullFromRemote
		{
			get
			{
				return Labels.ResourceManager.GetString("PullFromRemote", Labels.resourceCulture);
			}
		}
		public static string PullIntoLocalBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("PullIntoLocalBranch", Labels.resourceCulture);
			}
		}
		public static string PullMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("PullMenu", Labels.resourceCulture);
			}
		}
		public static string PullUpToHere
		{
			get
			{
				return Labels.ResourceManager.GetString("PullUpToHere", Labels.resourceCulture);
			}
		}
		public static string Push
		{
			get
			{
				return Labels.ResourceManager.GetString("Push", Labels.resourceCulture);
			}
		}
		public static string PushAllTags
		{
			get
			{
				return Labels.ResourceManager.GetString("PushAllTags", Labels.resourceCulture);
			}
		}
		public static string PushAllTagsToRemotes
		{
			get
			{
				return Labels.ResourceManager.GetString("PushAllTagsToRemotes", Labels.resourceCulture);
			}
		}
		public static string PushBranches
		{
			get
			{
				return Labels.ResourceManager.GetString("PushBranches", Labels.resourceCulture);
			}
		}
		public static string PushColumn
		{
			get
			{
				return Labels.ResourceManager.GetString("PushColumn", Labels.resourceCulture);
			}
		}
		public static string PushCommitImmediatelyTo
		{
			get
			{
				return Labels.ResourceManager.GetString("PushCommitImmediatelyTo", Labels.resourceCulture);
			}
		}
		public static string PushImmediately
		{
			get
			{
				return Labels.ResourceManager.GetString("PushImmediately", Labels.resourceCulture);
			}
		}
		public static string PushMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("PushMenu", Labels.resourceCulture);
			}
		}
		public static string PushTag
		{
			get
			{
				return Labels.ResourceManager.GetString("PushTag", Labels.resourceCulture);
			}
		}
		public static string PushToDefault
		{
			get
			{
				return Labels.ResourceManager.GetString("PushToDefault", Labels.resourceCulture);
			}
		}
		public static string PushToRepository
		{
			get
			{
				return Labels.ResourceManager.GetString("PushToRepository", Labels.resourceCulture);
			}
		}
		public static string Rebase
		{
			get
			{
				return Labels.ResourceManager.GetString("Rebase", Labels.resourceCulture);
			}
		}
		public static string RebaseInsteadOfMerge
		{
			get
			{
				return Labels.ResourceManager.GetString("RebaseInsteadOfMerge", Labels.resourceCulture);
			}
		}
		public static string RebaseMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("RebaseMenu", Labels.resourceCulture);
			}
		}
		public static string RecentMessages
		{
			get
			{
				return Labels.ResourceManager.GetString("RecentMessages", Labels.resourceCulture);
			}
		}
		public static string RecurseSubmodules
		{
			get
			{
				return Labels.ResourceManager.GetString("RecurseSubmodules", Labels.resourceCulture);
			}
		}
		public static string RedoMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("RedoMenu", Labels.resourceCulture);
			}
		}
		public static string Refresh
		{
			get
			{
				return Labels.ResourceManager.GetString("Refresh", Labels.resourceCulture);
			}
		}
		public static string RefreshAutomatically
		{
			get
			{
				return Labels.ResourceManager.GetString("RefreshAutomatically", Labels.resourceCulture);
			}
		}
		public static string RefreshMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("RefreshMenu", Labels.resourceCulture);
			}
		}
		public static string RefreshRemoteStatusMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("RefreshRemoteStatusMenu", Labels.resourceCulture);
			}
		}
		public static string RefreshRemoteStatusPerRepo
		{
			get
			{
				return Labels.ResourceManager.GetString("RefreshRemoteStatusPerRepo", Labels.resourceCulture);
			}
		}
		public static string RegexPatternLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("RegexPatternLabel", Labels.resourceCulture);
			}
		}
		public static string RegisteredTo
		{
			get
			{
				return Labels.ResourceManager.GetString("RegisteredTo", Labels.resourceCulture);
			}
		}
		public static string RegisterNow
		{
			get
			{
				return Labels.ResourceManager.GetString("RegisterNow", Labels.resourceCulture);
			}
		}
		public static string RegisterSourceTree
		{
			get
			{
				return Labels.ResourceManager.GetString("RegisterSourceTree", Labels.resourceCulture);
			}
		}
		public static string Registration
		{
			get
			{
				return Labels.ResourceManager.GetString("Registration", Labels.resourceCulture);
			}
		}
		public static string RegistrationMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("RegistrationMenu", Labels.resourceCulture);
			}
		}
		public static string ReleaseBranchPrefix
		{
			get
			{
				return Labels.ResourceManager.GetString("ReleaseBranchPrefix", Labels.resourceCulture);
			}
		}
		public static string ReleaseNotesMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ReleaseNotesMenu", Labels.resourceCulture);
			}
		}
		public static string Remote
		{
			get
			{
				return Labels.ResourceManager.GetString("Remote", Labels.resourceCulture);
			}
		}
		public static string RemoteBranchColumn
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoteBranchColumn", Labels.resourceCulture);
			}
		}
		public static string RemoteBranchLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoteBranchLabel", Labels.resourceCulture);
			}
		}
		public static string RemoteBranchToPull
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoteBranchToPull", Labels.resourceCulture);
			}
		}
		public static string RemoteDetails
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoteDetails", Labels.resourceCulture);
			}
		}
		public static string RemoteName
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoteName", Labels.resourceCulture);
			}
		}
		public static string RemoteRepositoryLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoteRepositoryLabel", Labels.resourceCulture);
			}
		}
		public static string RemoteRepositoryPaths
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoteRepositoryPaths", Labels.resourceCulture);
			}
		}
		public static string Remotes
		{
			get
			{
				return Labels.ResourceManager.GetString("Remotes", Labels.resourceCulture);
			}
		}
		public static string RemoteUrlActionTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoteUrlActionTitle", Labels.resourceCulture);
			}
		}
		public static string Remove
		{
			get
			{
				return Labels.ResourceManager.GetString("Remove", Labels.resourceCulture);
			}
		}
		public static string RemoveFile
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoveFile", Labels.resourceCulture);
			}
		}
		public static string RemoveTag
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoveTag", Labels.resourceCulture);
			}
		}
		public static string RemoveTagFromAllRemotes
		{
			get
			{
				return Labels.ResourceManager.GetString("RemoveTagFromAllRemotes", Labels.resourceCulture);
			}
		}
		public static string Rename
		{
			get
			{
				return Labels.ResourceManager.GetString("Rename", Labels.resourceCulture);
			}
		}
		public static string RenameBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("RenameBranch", Labels.resourceCulture);
			}
		}
		public static string RenameBranchFieldLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("RenameBranchFieldLabel", Labels.resourceCulture);
			}
		}
		public static string ReopenRepos
		{
			get
			{
				return Labels.ResourceManager.GetString("ReopenRepos", Labels.resourceCulture);
			}
		}
		public static string ReplacementTypeLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ReplacementTypeLabel", Labels.resourceCulture);
			}
		}
		public static string RepoMovedOrDeleted
		{
			get
			{
				return Labels.ResourceManager.GetString("RepoMovedOrDeleted", Labels.resourceCulture);
			}
		}
		public static string ReportBug
		{
			get
			{
				return Labels.ResourceManager.GetString("ReportBug", Labels.resourceCulture);
			}
		}
		public static string RepoSettings
		{
			get
			{
				return Labels.ResourceManager.GetString("RepoSettings", Labels.resourceCulture);
			}
		}
		public static string RepositoryGroupLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("RepositoryGroupLabel", Labels.resourceCulture);
			}
		}
		public static string RepositoryLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("RepositoryLabel", Labels.resourceCulture);
			}
		}
		public static string RepositoryMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("RepositoryMenu", Labels.resourceCulture);
			}
		}
		public static string RepositorySettingsMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("RepositorySettingsMenu", Labels.resourceCulture);
			}
		}
		public static string RepositoryType
		{
			get
			{
				return Labels.ResourceManager.GetString("RepositoryType", Labels.resourceCulture);
			}
		}
		public static string RepoSpecificIgnoreList
		{
			get
			{
				return Labels.ResourceManager.GetString("RepoSpecificIgnoreList", Labels.resourceCulture);
			}
		}
		public static string RequestNewFeatureMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("RequestNewFeatureMenu", Labels.resourceCulture);
			}
		}
		public static string RequiredInformation
		{
			get
			{
				return Labels.ResourceManager.GetString("RequiredInformation", Labels.resourceCulture);
			}
		}
		public static string RequiresRestart
		{
			get
			{
				return Labels.ResourceManager.GetString("RequiresRestart", Labels.resourceCulture);
			}
		}
		public static string Reset
		{
			get
			{
				return Labels.ResourceManager.GetString("Reset", Labels.resourceCulture);
			}
		}
		public static string ResetAll
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetAll", Labels.resourceCulture);
			}
		}
		public static string ResetAllDescription
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetAllDescription", Labels.resourceCulture);
			}
		}
		public static string ResetBranch
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetBranch", Labels.resourceCulture);
			}
		}
		public static string ResetBranchLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetBranchLabel", Labels.resourceCulture);
			}
		}
		public static string ResetBranchText
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetBranchText", Labels.resourceCulture);
			}
		}
		public static string ResetHardMode
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetHardMode", Labels.resourceCulture);
			}
		}
		public static string ResetMixedMode
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetMixedMode", Labels.resourceCulture);
			}
		}
		public static string ResetSoftMode
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetSoftMode", Labels.resourceCulture);
			}
		}
		public static string ResetToCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetToCommit", Labels.resourceCulture);
			}
		}
		public static string ResetToCommitMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetToCommitMenu", Labels.resourceCulture);
			}
		}
		public static string ResetToThisCommitMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ResetToThisCommitMenu", Labels.resourceCulture);
			}
		}
		public static string ResolveConflictsMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ResolveConflictsMenu", Labels.resourceCulture);
			}
		}
		public static string ResolveUsingMineMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ResolveUsingMineMenu", Labels.resourceCulture);
			}
		}
		public static string ResolveUsingTheirsMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ResolveUsingTheirsMenu", Labels.resourceCulture);
			}
		}
		public static string RestartMergeMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("RestartMergeMenu", Labels.resourceCulture);
			}
		}
		public static string Restore
		{
			get
			{
				return Labels.ResourceManager.GetString("Restore", Labels.resourceCulture);
			}
		}
		public static string Retry
		{
			get
			{
				return Labels.ResourceManager.GetString("Retry", Labels.resourceCulture);
			}
		}
		public static string ReverseCommitMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ReverseCommitMenu", Labels.resourceCulture);
			}
		}
		public static string ReverseFile
		{
			get
			{
				return Labels.ResourceManager.GetString("ReverseFile", Labels.resourceCulture);
			}
		}
		public static string ReverseHunk
		{
			get
			{
				return Labels.ResourceManager.GetString("ReverseHunk", Labels.resourceCulture);
			}
		}
		public static string ReverseLines
		{
			get
			{
				return Labels.ResourceManager.GetString("ReverseLines", Labels.resourceCulture);
			}
		}
		public static string RootFolder
		{
			get
			{
				return Labels.ResourceManager.GetString("RootFolder", Labels.resourceCulture);
			}
		}
		public static string RootUrlLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("RootUrlLabel", Labels.resourceCulture);
			}
		}
		public static string SavedPasswords
		{
			get
			{
				return Labels.ResourceManager.GetString("SavedPasswords", Labels.resourceCulture);
			}
		}
		public static string ScriptTarget
		{
			get
			{
				return Labels.ResourceManager.GetString("ScriptTarget", Labels.resourceCulture);
			}
		}
		public static string ScriptToRunLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ScriptToRunLabel", Labels.resourceCulture);
			}
		}
		public static string Search
		{
			get
			{
				return Labels.ResourceManager.GetString("Search", Labels.resourceCulture);
			}
		}
		public static string SearchAuthors
		{
			get
			{
				return Labels.ResourceManager.GetString("SearchAuthors", Labels.resourceCulture);
			}
		}
		public static string SearchCommitMessage
		{
			get
			{
				return Labels.ResourceManager.GetString("SearchCommitMessage", Labels.resourceCulture);
			}
		}
		public static string SearchFileChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("SearchFileChanges", Labels.resourceCulture);
			}
		}
		public static string SearchLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("SearchLabel", Labels.resourceCulture);
			}
		}
		public static string SearchViewMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SearchViewMenu", Labels.resourceCulture);
			}
		}
		public static string SearchViewTab
		{
			get
			{
				return Labels.ResourceManager.GetString("SearchViewTab", Labels.resourceCulture);
			}
		}
		public static string SelectAll
		{
			get
			{
				return Labels.ResourceManager.GetString("SelectAll", Labels.resourceCulture);
			}
		}
		public static string SelectAllMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SelectAllMenu", Labels.resourceCulture);
			}
		}
		public static string SelectBranchesToDelete
		{
			get
			{
				return Labels.ResourceManager.GetString("SelectBranchesToDelete", Labels.resourceCulture);
			}
		}
		public static string SelectProjects
		{
			get
			{
				return Labels.ResourceManager.GetString("SelectProjects", Labels.resourceCulture);
			}
		}
		public static string SelectTheCommitToSwitchTo
		{
			get
			{
				return Labels.ResourceManager.GetString("SelectTheCommitToSwitchTo", Labels.resourceCulture);
			}
		}
		public static string ServerLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ServerLabel", Labels.resourceCulture);
			}
		}
		public static string SetDefault
		{
			get
			{
				return Labels.ResourceManager.GetString("SetDefault", Labels.resourceCulture);
			}
		}
		public static string Settings
		{
			get
			{
				return Labels.ResourceManager.GetString("Settings", Labels.resourceCulture);
			}
		}
		public static string SetupWizardMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SetupWizardMenu", Labels.resourceCulture);
			}
		}
		public static string Shelve
		{
			get
			{
				return Labels.ResourceManager.GetString("Shelve", Labels.resourceCulture);
			}
		}
		public static string ShelveMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ShelveMenu", Labels.resourceCulture);
			}
		}
		public static string ShowAll
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowAll", Labels.resourceCulture);
			}
		}
		public static string ShowClean
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowClean", Labels.resourceCulture);
			}
		}
		public static string ShowConflicts
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowConflicts", Labels.resourceCulture);
			}
		}
		public static string ShowFileChangesForAllSidesOfMerges
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowFileChangesForAllSidesOfMerges", Labels.resourceCulture);
			}
		}
		public static string ShowFullOutput
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowFullOutput", Labels.resourceCulture);
			}
		}
		public static string ShowHideBookmarksMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowHideBookmarksMenu", Labels.resourceCulture);
			}
		}
		public static string ShowHostedReposMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowHostedReposMenu", Labels.resourceCulture);
			}
		}
		public static string ShowIgnored
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowIgnored", Labels.resourceCulture);
			}
		}
		public static string ShowInExplorer
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowInExplorer", Labels.resourceCulture);
			}
		}
		public static string ShowInExplorerMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowInExplorerMenu", Labels.resourceCulture);
			}
		}
		public static string ShowModified
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowModified", Labels.resourceCulture);
			}
		}
		public static string ShowOnly
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowOnly", Labels.resourceCulture);
			}
		}
		public static string ShowPending
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowPending", Labels.resourceCulture);
			}
		}
		public static string ShowPrivate
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowPrivate", Labels.resourceCulture);
			}
		}
		public static string ShowPrivateRepositories
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowPrivateRepositories", Labels.resourceCulture);
			}
		}
		public static string ShowRemoteBranches
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowRemoteBranches", Labels.resourceCulture);
			}
		}
		public static string ShowUntracked
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowUntracked", Labels.resourceCulture);
			}
		}
		public static string ShowWhitespace
		{
			get
			{
				return Labels.ResourceManager.GetString("ShowWhitespace", Labels.resourceCulture);
			}
		}
		public static string SidebarApplyStashMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarApplyStashMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarBookmarks
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarBookmarks", Labels.resourceCulture);
			}
		}
		public static string SidebarBranches
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarBranches", Labels.resourceCulture);
			}
		}
		public static string SidebarChangeSourceURL
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarChangeSourceURL", Labels.resourceCulture);
			}
		}
		public static string SidebarCheckoutMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarCheckoutMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarCloseBranchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarCloseBranchMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarDeleteMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarDeleteMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarDeleteShelveMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarDeleteShelveMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarDeleteStashMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarDeleteStashMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarDetailsMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarDetailsMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarEditMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarEditMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarFileStatus
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarFileStatus", Labels.resourceCulture);
			}
		}
		public static string SidebarMergeMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarMergeMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarOpenMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarOpenMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarPullBranchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarPullBranchMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarPullMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarPullMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarPullRemoteBranchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarPullRemoteBranchMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarPushBranchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarPushBranchMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarPushMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarPushMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarPushToMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarPushToMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarRebaseMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarRebaseMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarRemoteFetchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarRemoteFetchMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarRemotePullMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarRemotePullMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarRemotePushMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarRemotePushMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarRemotes
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarRemotes", Labels.resourceCulture);
			}
		}
		public static string SidebarRenameMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarRenameMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarShelves
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarShelves", Labels.resourceCulture);
			}
		}
		public static string SidebarStashes
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarStashes", Labels.resourceCulture);
			}
		}
		public static string SidebarSubmodules
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarSubmodules", Labels.resourceCulture);
			}
		}
		public static string SidebarSubrepos
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarSubrepos", Labels.resourceCulture);
			}
		}
		public static string SidebarSubtrees
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarSubtrees", Labels.resourceCulture);
			}
		}
		public static string SidebarTags
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarTags", Labels.resourceCulture);
			}
		}
		public static string SidebarTrackNone
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarTrackNone", Labels.resourceCulture);
			}
		}
		public static string SidebarTrackRemoteBranchMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarTrackRemoteBranchMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarUnshelveMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarUnshelveMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarUpdateMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarUpdateMenu", Labels.resourceCulture);
			}
		}
		public static string SidebarWorkingCopy
		{
			get
			{
				return Labels.ResourceManager.GetString("SidebarWorkingCopy", Labels.resourceCulture);
			}
		}
		public static string Signoff
		{
			get
			{
				return Labels.ResourceManager.GetString("Signoff", Labels.resourceCulture);
			}
		}
		public static string SignupFree
		{
			get
			{
				return Labels.ResourceManager.GetString("SignupFree", Labels.resourceCulture);
			}
		}
		public static string Simple
		{
			get
			{
				return Labels.ResourceManager.GetString("Simple", Labels.resourceCulture);
			}
		}
		public static string SizeLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("SizeLabel", Labels.resourceCulture);
			}
		}
		public static string SizeLimitBinary
		{
			get
			{
				return Labels.ResourceManager.GetString("SizeLimitBinary", Labels.resourceCulture);
			}
		}
		public static string SizeLimitText
		{
			get
			{
				return Labels.ResourceManager.GetString("SizeLimitText", Labels.resourceCulture);
			}
		}
		public static string Skip
		{
			get
			{
				return Labels.ResourceManager.GetString("Skip", Labels.resourceCulture);
			}
		}
		public static string SkipSetup
		{
			get
			{
				return Labels.ResourceManager.GetString("SkipSetup", Labels.resourceCulture);
			}
		}
		public static string SkipTest
		{
			get
			{
				return Labels.ResourceManager.GetString("SkipTest", Labels.resourceCulture);
			}
		}
		public static string SortBy
		{
			get
			{
				return Labels.ResourceManager.GetString("SortBy", Labels.resourceCulture);
			}
		}
		public static string SortCheckedUnchecked
		{
			get
			{
				return Labels.ResourceManager.GetString("SortCheckedUnchecked", Labels.resourceCulture);
			}
		}
		public static string SortCheckedUncheckedShort
		{
			get
			{
				return Labels.ResourceManager.GetString("SortCheckedUncheckedShort", Labels.resourceCulture);
			}
		}
		public static string SortedBy
		{
			get
			{
				return Labels.ResourceManager.GetString("SortedBy", Labels.resourceCulture);
			}
		}
		public static string SortedByCheckedUnchecked
		{
			get
			{
				return Labels.ResourceManager.GetString("SortedByCheckedUnchecked", Labels.resourceCulture);
			}
		}
		public static string SortedByFilename
		{
			get
			{
				return Labels.ResourceManager.GetString("SortedByFilename", Labels.resourceCulture);
			}
		}
		public static string SortedByFilenameReversed
		{
			get
			{
				return Labels.ResourceManager.GetString("SortedByFilenameReversed", Labels.resourceCulture);
			}
		}
		public static string SortedByFileStatus
		{
			get
			{
				return Labels.ResourceManager.GetString("SortedByFileStatus", Labels.resourceCulture);
			}
		}
		public static string SortedByPath
		{
			get
			{
				return Labels.ResourceManager.GetString("SortedByPath", Labels.resourceCulture);
			}
		}
		public static string SortedByPathReversed
		{
			get
			{
				return Labels.ResourceManager.GetString("SortedByPathReversed", Labels.resourceCulture);
			}
		}
		public static string SortFilenameAlphabetically
		{
			get
			{
				return Labels.ResourceManager.GetString("SortFilenameAlphabetically", Labels.resourceCulture);
			}
		}
		public static string SortFilenameAlphabeticallyReversed
		{
			get
			{
				return Labels.ResourceManager.GetString("SortFilenameAlphabeticallyReversed", Labels.resourceCulture);
			}
		}
		public static string SortFilenameAlphabeticallyReversedShort
		{
			get
			{
				return Labels.ResourceManager.GetString("SortFilenameAlphabeticallyReversedShort", Labels.resourceCulture);
			}
		}
		public static string SortFilenameAlphabeticallyShort
		{
			get
			{
				return Labels.ResourceManager.GetString("SortFilenameAlphabeticallyShort", Labels.resourceCulture);
			}
		}
		public static string SortFileStatus
		{
			get
			{
				return Labels.ResourceManager.GetString("SortFileStatus", Labels.resourceCulture);
			}
		}
		public static string SortFileStatusShort
		{
			get
			{
				return Labels.ResourceManager.GetString("SortFileStatusShort", Labels.resourceCulture);
			}
		}
		public static string SortPathAlphabetically
		{
			get
			{
				return Labels.ResourceManager.GetString("SortPathAlphabetically", Labels.resourceCulture);
			}
		}
		public static string SortPathAlphabeticallyReversed
		{
			get
			{
				return Labels.ResourceManager.GetString("SortPathAlphabeticallyReversed", Labels.resourceCulture);
			}
		}
		public static string SortPathAlphabeticallyReversedShort
		{
			get
			{
				return Labels.ResourceManager.GetString("SortPathAlphabeticallyReversedShort", Labels.resourceCulture);
			}
		}
		public static string SortPathAlphabeticallyShort
		{
			get
			{
				return Labels.ResourceManager.GetString("SortPathAlphabeticallyShort", Labels.resourceCulture);
			}
		}
		public static string SourceBranchLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("SourceBranchLabel", Labels.resourceCulture);
			}
		}
		public static string SourcePath
		{
			get
			{
				return Labels.ResourceManager.GetString("SourcePath", Labels.resourceCulture);
			}
		}
		public static string SpecifiedCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("SpecifiedCommit", Labels.resourceCulture);
			}
		}
		public static string SpellCheckCommits
		{
			get
			{
				return Labels.ResourceManager.GetString("SpellCheckCommits", Labels.resourceCulture);
			}
		}
		public static string SplitViewStaging
		{
			get
			{
				return Labels.ResourceManager.GetString("SplitViewStaging", Labels.resourceCulture);
			}
		}
		public static string SquashWithPrevious
		{
			get
			{
				return Labels.ResourceManager.GetString("SquashWithPrevious", Labels.resourceCulture);
			}
		}
		public static string SquashWithPreviousCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("SquashWithPreviousCommit", Labels.resourceCulture);
			}
		}
		public static string SSHClientAnnotation
		{
			get
			{
				return Labels.ResourceManager.GetString("SSHClientAnnotation", Labels.resourceCulture);
			}
		}
		public static string SSHClientConfiguration
		{
			get
			{
				return Labels.ResourceManager.GetString("SSHClientConfiguration", Labels.resourceCulture);
			}
		}
		public static string SSHClientLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("SSHClientLabel", Labels.resourceCulture);
			}
		}
		public static string StageAll
		{
			get
			{
				return Labels.ResourceManager.GetString("StageAll", Labels.resourceCulture);
			}
		}
		public static string StagedChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("StagedChanges", Labels.resourceCulture);
			}
		}
		public static string StagedFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("StagedFiles", Labels.resourceCulture);
			}
		}
		public static string StageFile
		{
			get
			{
				return Labels.ResourceManager.GetString("StageFile", Labels.resourceCulture);
			}
		}
		public static string StageHunk
		{
			get
			{
				return Labels.ResourceManager.GetString("StageHunk", Labels.resourceCulture);
			}
		}
		public static string StageLines
		{
			get
			{
				return Labels.ResourceManager.GetString("StageLines", Labels.resourceCulture);
			}
		}
		public static string StageSelected
		{
			get
			{
				return Labels.ResourceManager.GetString("StageSelected", Labels.resourceCulture);
			}
		}
		public static string StagingFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("StagingFiles", Labels.resourceCulture);
			}
		}
		public static string StartAtLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("StartAtLabel", Labels.resourceCulture);
			}
		}
		public static string StartSSHAgentAutomatically
		{
			get
			{
				return Labels.ResourceManager.GetString("StartSSHAgentAutomatically", Labels.resourceCulture);
			}
		}
		public static string Stash
		{
			get
			{
				return Labels.ResourceManager.GetString("Stash", Labels.resourceCulture);
			}
		}
		public static string StashMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("StashMenu", Labels.resourceCulture);
			}
		}
		public static string StashURL
		{
			get
			{
				return Labels.ResourceManager.GetString("StashURL", Labels.resourceCulture);
			}
		}
		public static string StatusAdded
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusAdded", Labels.resourceCulture);
			}
		}
		public static string StatusClean
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusClean", Labels.resourceCulture);
			}
		}
		public static string StatusConflicted
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusConflicted", Labels.resourceCulture);
			}
		}
		public static string StatusIgnored
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusIgnored", Labels.resourceCulture);
			}
		}
		public static string StatusMerged
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusMerged", Labels.resourceCulture);
			}
		}
		public static string StatusMissing
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusMissing", Labels.resourceCulture);
			}
		}
		public static string StatusModified
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusModified", Labels.resourceCulture);
			}
		}
		public static string StatusRemoved
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusRemoved", Labels.resourceCulture);
			}
		}
		public static string StatusRenamed
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusRenamed", Labels.resourceCulture);
			}
		}
		public static string StatusSubrepoChanged
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusSubrepoChanged", Labels.resourceCulture);
			}
		}
		public static string StatusUnknown
		{
			get
			{
				return Labels.ResourceManager.GetString("StatusUnknown", Labels.resourceCulture);
			}
		}
		public static string StopTrackingMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("StopTrackingMenu", Labels.resourceCulture);
			}
		}
		public static string String1
		{
			get
			{
				return Labels.ResourceManager.GetString("String1", Labels.resourceCulture);
			}
		}
		public static string StripFromHereMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("StripFromHereMenu", Labels.resourceCulture);
			}
		}
		public static string StripLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("StripLabel", Labels.resourceCulture);
			}
		}
		public static string SubmitViaRemoteLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("SubmitViaRemoteLabel", Labels.resourceCulture);
			}
		}
		public static string Submodule
		{
			get
			{
				return Labels.ResourceManager.GetString("Submodule", Labels.resourceCulture);
			}
		}
		public static string SubmoduleCheck
		{
			get
			{
				return Labels.ResourceManager.GetString("SubmoduleCheck", Labels.resourceCulture);
			}
		}
		public static string SubmodulesWithUncommitted
		{
			get
			{
				return Labels.ResourceManager.GetString("SubmodulesWithUncommitted", Labels.resourceCulture);
			}
		}
		public static string SubmodulesWithUnpushed
		{
			get
			{
				return Labels.ResourceManager.GetString("SubmodulesWithUnpushed", Labels.resourceCulture);
			}
		}
		public static string Subrepository
		{
			get
			{
				return Labels.ResourceManager.GetString("Subrepository", Labels.resourceCulture);
			}
		}
		public static string SubrepositoryCheck
		{
			get
			{
				return Labels.ResourceManager.GetString("SubrepositoryCheck", Labels.resourceCulture);
			}
		}
		public static string SubreposWithUncommitted
		{
			get
			{
				return Labels.ResourceManager.GetString("SubreposWithUncommitted", Labels.resourceCulture);
			}
		}
		public static string SubreposWithUnpushed
		{
			get
			{
				return Labels.ResourceManager.GetString("SubreposWithUnpushed", Labels.resourceCulture);
			}
		}
		public static string SubtreeBranchCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("SubtreeBranchCommit", Labels.resourceCulture);
			}
		}
		public static string SubtreeLocalRelativePath
		{
			get
			{
				return Labels.ResourceManager.GetString("SubtreeLocalRelativePath", Labels.resourceCulture);
			}
		}
		public static string SubtreeSourcePathUrl
		{
			get
			{
				return Labels.ResourceManager.GetString("SubtreeSourcePathUrl", Labels.resourceCulture);
			}
		}
		public static string SubtreeSquashLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("SubtreeSquashLabel", Labels.resourceCulture);
			}
		}
		public static string SummaryTextCopyRename
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextCopyRename", Labels.resourceCulture);
			}
		}
		public static string SummaryTextDeletedBinary
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextDeletedBinary", Labels.resourceCulture);
			}
		}
		public static string SummaryTextDeletedFile
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextDeletedFile", Labels.resourceCulture);
			}
		}
		public static string SummaryTextDiffSuppressed
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextDiffSuppressed", Labels.resourceCulture);
			}
		}
		public static string SummaryTextFileContents
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextFileContents", Labels.resourceCulture);
			}
		}
		public static string SummaryTextHunk
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextHunk", Labels.resourceCulture);
			}
		}
		public static string SummaryTextLines
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextLines", Labels.resourceCulture);
			}
		}
		public static string SummaryTextLinesAdded
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextLinesAdded", Labels.resourceCulture);
			}
		}
		public static string SummaryTextLinesRemoved
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextLinesRemoved", Labels.resourceCulture);
			}
		}
		public static string SummaryTextMode
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextMode", Labels.resourceCulture);
			}
		}
		public static string SummaryTextModifiedBinary
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextModifiedBinary", Labels.resourceCulture);
			}
		}
		public static string SummaryTextModifiedFile
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextModifiedFile", Labels.resourceCulture);
			}
		}
		public static string SummaryTextNewBinary
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextNewBinary", Labels.resourceCulture);
			}
		}
		public static string SummaryTextNewFile
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextNewFile", Labels.resourceCulture);
			}
		}
		public static string SummaryTextSubrepoCommitChanged
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextSubrepoCommitChanged", Labels.resourceCulture);
			}
		}
		public static string SummaryTextUnmodified
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextUnmodified", Labels.resourceCulture);
			}
		}
		public static string SummaryTextUntrackedBinary
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextUntrackedBinary", Labels.resourceCulture);
			}
		}
		public static string SummaryTextUntrackedFile
		{
			get
			{
				return Labels.ResourceManager.GetString("SummaryTextUntrackedFile", Labels.resourceCulture);
			}
		}
		public static string SupportMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("SupportMenu", Labels.resourceCulture);
			}
		}
		public static string SystemGit
		{
			get
			{
				return Labels.ResourceManager.GetString("SystemGit", Labels.resourceCulture);
			}
		}
		public static string SystemHg
		{
			get
			{
				return Labels.ResourceManager.GetString("SystemHg", Labels.resourceCulture);
			}
		}
		public static string Tag
		{
			get
			{
				return Labels.ResourceManager.GetString("Tag", Labels.resourceCulture);
			}
		}
		public static string TagMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("TagMenu", Labels.resourceCulture);
			}
		}
		public static string TagName
		{
			get
			{
				return Labels.ResourceManager.GetString("TagName", Labels.resourceCulture);
			}
		}
		public static string TagToRemove
		{
			get
			{
				return Labels.ResourceManager.GetString("TagToRemove", Labels.resourceCulture);
			}
		}
		public static string Terminal
		{
			get
			{
                return "GitBash"; //Labels.ResourceManager.GetString("Terminal", Labels.resourceCulture);
			}
		}
		public static string TestingConnections
		{
			get
			{
				return Labels.ResourceManager.GetString("TestingConnections", Labels.resourceCulture);
			}
		}
		public static string ThankYouForRegistering
		{
			get
			{
				return Labels.ResourceManager.GetString("ThankYouForRegistering", Labels.resourceCulture);
			}
		}
		public static string ToCommitLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ToCommitLabel", Labels.resourceCulture);
			}
		}
		public static string ToLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("ToLabel", Labels.resourceCulture);
			}
		}
		public static string ToolsMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ToolsMenu", Labels.resourceCulture);
			}
		}
		public static string TrackColumn
		{
			get
			{
				return Labels.ResourceManager.GetString("TrackColumn", Labels.resourceCulture);
			}
		}
		public static string TreeView
		{
			get
			{
				return Labels.ResourceManager.GetString("TreeView", Labels.resourceCulture);
			}
		}
		public static string TrialPeriodExpired
		{
			get
			{
				return Labels.ResourceManager.GetString("TrialPeriodExpired", Labels.resourceCulture);
			}
		}
		public static string TrialVersionExpiresIn
		{
			get
			{
				return Labels.ResourceManager.GetString("TrialVersionExpiresIn", Labels.resourceCulture);
			}
		}
		public static string Type
		{
			get
			{
				return Labels.ResourceManager.GetString("Type", Labels.resourceCulture);
			}
		}
		public static string UncommittedChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("UncommittedChanges", Labels.resourceCulture);
			}
		}
		public static string UncommittedChangesClean
		{
			get
			{
				return Labels.ResourceManager.GetString("UncommittedChangesClean", Labels.resourceCulture);
			}
		}
		public static string UncommittedChangesDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("UncommittedChangesDesc", Labels.resourceCulture);
			}
		}
		public static string UncommittedChangesDoNothing
		{
			get
			{
				return Labels.ResourceManager.GetString("UncommittedChangesDoNothing", Labels.resourceCulture);
			}
		}
		public static string UncommittedChangesShelve
		{
			get
			{
				return Labels.ResourceManager.GetString("UncommittedChangesShelve", Labels.resourceCulture);
			}
		}
		public static string UncommittedChangesStash
		{
			get
			{
				return Labels.ResourceManager.GetString("UncommittedChangesStash", Labels.resourceCulture);
			}
		}
		public static string UndoMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("UndoMenu", Labels.resourceCulture);
			}
		}
		public static string Unknown
		{
			get
			{
				return Labels.ResourceManager.GetString("Unknown", Labels.resourceCulture);
			}
		}
		public static string UnstageAll
		{
			get
			{
				return Labels.ResourceManager.GetString("UnstageAll", Labels.resourceCulture);
			}
		}
		public static string UnstagedFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("UnstagedFiles", Labels.resourceCulture);
			}
		}
		public static string UnstageFile
		{
			get
			{
				return Labels.ResourceManager.GetString("UnstageFile", Labels.resourceCulture);
			}
		}
		public static string UnstageFromIndex
		{
			get
			{
				return Labels.ResourceManager.GetString("UnstageFromIndex", Labels.resourceCulture);
			}
		}
		public static string UnstageHunk
		{
			get
			{
				return Labels.ResourceManager.GetString("UnstageHunk", Labels.resourceCulture);
			}
		}
		public static string UnstageLines
		{
			get
			{
				return Labels.ResourceManager.GetString("UnstageLines", Labels.resourceCulture);
			}
		}
		public static string UnstageSelected
		{
			get
			{
				return Labels.ResourceManager.GetString("UnstageSelected", Labels.resourceCulture);
			}
		}
		public static string UnstagingFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("UnstagingFiles", Labels.resourceCulture);
			}
		}
		public static string UntrackedFiles
		{
			get
			{
				return Labels.ResourceManager.GetString("UntrackedFiles", Labels.resourceCulture);
			}
		}
		public static string UpArrow
		{
			get
			{
				return Labels.ResourceManager.GetString("UpArrow", Labels.resourceCulture);
			}
		}
		public static string Update
		{
			get
			{
				return Labels.ResourceManager.GetString("Update", Labels.resourceCulture);
			}
		}
		public static string UpdateEmbeddedGit
		{
			get
			{
				return Labels.ResourceManager.GetString("UpdateEmbeddedGit", Labels.resourceCulture);
			}
		}
		public static string UpdateEmbeddedHg
		{
			get
			{
				return Labels.ResourceManager.GetString("UpdateEmbeddedHg", Labels.resourceCulture);
			}
		}
		public static string UpdateMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("UpdateMenu", Labels.resourceCulture);
			}
		}
		public static string UpdateMergeAndCommit
		{
			get
			{
				return Labels.ResourceManager.GetString("UpdateMergeAndCommit", Labels.resourceCulture);
			}
		}
		public static string UpdateNow
		{
			get
			{
				return Labels.ResourceManager.GetString("UpdateNow", Labels.resourceCulture);
			}
		}
		public static string UpdateToCommitLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("UpdateToCommitLabel", Labels.resourceCulture);
			}
		}
		public static string Upstream
		{
			get
			{
				return Labels.ResourceManager.GetString("Upstream", Labels.resourceCulture);
			}
		}
		public static string URLPath
		{
			get
			{
				return Labels.ResourceManager.GetString("URLPath", Labels.resourceCulture);
			}
		}
		public static string UseAlternativeAuthor
		{
			get
			{
				return Labels.ResourceManager.GetString("UseAlternativeAuthor", Labels.resourceCulture);
			}
		}
		public static string UseDefaultAuthor
		{
			get
			{
				return Labels.ResourceManager.GetString("UseDefaultAuthor", Labels.resourceCulture);
			}
		}
		public static string UseDefaults
		{
			get
			{
				return Labels.ResourceManager.GetString("UseDefaults", Labels.resourceCulture);
			}
		}
		public static string UseDetailsForAllRepos
		{
			get
			{
				return Labels.ResourceManager.GetString("UseDetailsForAllRepos", Labels.resourceCulture);
			}
		}
		public static string UseEmbeddedGit
		{
			get
			{
				return Labels.ResourceManager.GetString("UseEmbeddedGit", Labels.resourceCulture);
			}
		}
		public static string UseEmbeddedHg
		{
			get
			{
				return Labels.ResourceManager.GetString("UseEmbeddedHg", Labels.resourceCulture);
			}
		}
		public static string UseFixedWidthCommitFont
		{
			get
			{
				return Labels.ResourceManager.GetString("UseFixedWidthCommitFont", Labels.resourceCulture);
			}
		}
		public static string UseGitBashForTerminal
		{
			get
			{
				return Labels.ResourceManager.GetString("UseGitBashForTerminal", Labels.resourceCulture);
			}
		}
		public static string UseGlobalUserSettings
		{
			get
			{
				return Labels.ResourceManager.GetString("UseGlobalUserSettings", Labels.resourceCulture);
			}
		}
		public static string UseRebaseForTracked
		{
			get
			{
				return Labels.ResourceManager.GetString("UseRebaseForTracked", Labels.resourceCulture);
			}
		}
		public static string UserInformation
		{
			get
			{
				return Labels.ResourceManager.GetString("UserInformation", Labels.resourceCulture);
			}
		}
		public static string Username
		{
			get
			{
				return Labels.ResourceManager.GetString("Username", Labels.resourceCulture);
			}
		}
		public static string UsernameAndPassword
		{
			get
			{
				return Labels.ResourceManager.GetString("UsernameAndPassword", Labels.resourceCulture);
			}
		}
		public static string UsernameLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("UsernameLabel", Labels.resourceCulture);
			}
		}
		public static string UseSystemGit
		{
			get
			{
				return Labels.ResourceManager.GetString("UseSystemGit", Labels.resourceCulture);
			}
		}
		public static string UseSystemHg
		{
			get
			{
				return Labels.ResourceManager.GetString("UseSystemHg", Labels.resourceCulture);
			}
		}
		public static string UseTheStagingArea
		{
			get
			{
				return Labels.ResourceManager.GetString("UseTheStagingArea", Labels.resourceCulture);
			}
		}
		public static string UsingModeLabel
		{
			get
			{
				return Labels.ResourceManager.GetString("UsingModeLabel", Labels.resourceCulture);
			}
		}
		public static string Version
		{
			get
			{
				return Labels.ResourceManager.GetString("Version", Labels.resourceCulture);
			}
		}
		public static string VersionTagPrefix
		{
			get
			{
				return Labels.ResourceManager.GetString("VersionTagPrefix", Labels.resourceCulture);
			}
		}
		public static string ViewInFileLog
		{
			get
			{
				return Labels.ResourceManager.GetString("ViewInFileLog", Labels.resourceCulture);
			}
		}
		public static string ViewInFullLog
		{
			get
			{
				return Labels.ResourceManager.GetString("ViewInFullLog", Labels.resourceCulture);
			}
		}
		public static string ViewMenu
		{
			get
			{
				return Labels.ResourceManager.GetString("ViewMenu", Labels.resourceCulture);
			}
		}
		public static string VisualMergeAnnotation
		{
			get
			{
				return Labels.ResourceManager.GetString("VisualMergeAnnotation", Labels.resourceCulture);
			}
		}
		public static string VisualMergeDetailsGroup
		{
			get
			{
				return Labels.ResourceManager.GetString("VisualMergeDetailsGroup", Labels.resourceCulture);
			}
		}
		public static string VisualMergeTitle
		{
			get
			{
				return Labels.ResourceManager.GetString("VisualMergeTitle", Labels.resourceCulture);
			}
		}
		public static string Welcome
		{
			get
			{
				return Labels.ResourceManager.GetString("Welcome", Labels.resourceCulture);
			}
		}
		public static string WelcomeAgreeLicenseLinkedText
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeAgreeLicenseLinkedText", Labels.resourceCulture);
			}
		}
		public static string WelcomeAgreeLicensePreText
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeAgreeLicensePreText", Labels.resourceCulture);
			}
		}
		public static string WelcomeBitbucketDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeBitbucketDesc", Labels.resourceCulture);
			}
		}
		public static string WelcomeDefaultLineEndingHandling
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeDefaultLineEndingHandling", Labels.resourceCulture);
			}
		}
		public static string WelcomeHostingLeader
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeHostingLeader", Labels.resourceCulture);
			}
		}
		public static string WelcomeMainLeader
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeMainLeader", Labels.resourceCulture);
			}
		}
		public static string WelcomeStashDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeStashDesc", Labels.resourceCulture);
			}
		}
		public static string WelcomeUseOpenSSH
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeUseOpenSSH", Labels.resourceCulture);
			}
		}
		public static string WelcomeUseOpenSSHDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeUseOpenSSHDesc", Labels.resourceCulture);
			}
		}
		public static string WelcomeUsePuTTY
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeUsePuTTY", Labels.resourceCulture);
			}
		}
		public static string WelcomeUsePuTTYDesc
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeUsePuTTYDesc", Labels.resourceCulture);
			}
		}
		public static string WelcomeUserAnnotation
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeUserAnnotation", Labels.resourceCulture);
			}
		}
		public static string WelcomeUserLeader
		{
			get
			{
				return Labels.ResourceManager.GetString("WelcomeUserLeader", Labels.resourceCulture);
			}
		}
		public static string Why
		{
			get
			{
				return Labels.ResourceManager.GetString("Why", Labels.resourceCulture);
			}
		}
		public static string WorkingCopyChanges
		{
			get
			{
				return Labels.ResourceManager.GetString("WorkingCopyChanges", Labels.resourceCulture);
			}
		}
		public static string WorkingCopyParent
		{
			get
			{
				return Labels.ResourceManager.GetString("WorkingCopyParent", Labels.resourceCulture);
			}
		}
		public static string WorkingCopyPath
		{
			get
			{
				return Labels.ResourceManager.GetString("WorkingCopyPath", Labels.resourceCulture);
			}
		}
		internal Labels()
		{
		}
	}
}
