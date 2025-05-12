; ModuleID = 'obj\Debug\130\android\marshal_methods.x86_64.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [272 x i64] [
	i64 15690660930947125, ; 0: Microsoft.DotNet.PlatformAbstractions.dll => 0x37be92af148835 => 31
	i64 24362543149721218, ; 1: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 83
	i64 98382396393917666, ; 2: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 44
	i64 120698629574877762, ; 3: Mono.Android => 0x1accec39cafe242 => 46
	i64 160518225272466977, ; 4: Microsoft.Extensions.Hosting.Abstractions => 0x23a4679b5576e21 => 38
	i64 210515253464952879, ; 5: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 73
	i64 232391251801502327, ; 6: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 105
	i64 295915112840604065, ; 7: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 106
	i64 535107122908063503, ; 8: Microsoft.Extensions.ObjectPool.dll => 0x76d1517d9b7670f => 42
	i64 634308326490598313, ; 9: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 92
	i64 702024105029695270, ; 10: System.Drawing.Common => 0x9be17343c0e7726 => 125
	i64 720058930071658100, ; 11: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 86
	i64 864641107619353643, ; 12: Microsoft.AspNetCore.Mvc.DataAnnotations => 0xbffd2819dda142b => 26
	i64 872800313462103108, ; 13: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 82
	i64 881364984610509084, ; 14: SeenIT => 0xc3b3cc8a92d511c => 49
	i64 940822596282819491, ; 15: System.Transactions => 0xd0e792aa81923a3 => 123
	i64 982068613551266738, ; 16: Microsoft.AspNetCore.ResponseCaching.Abstractions.dll => 0xda1023367c89bb2 => 27
	i64 996343623809489702, ; 17: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 118
	i64 1000557547492888992, ; 18: Mono.Security.dll => 0xde2b1c9cba651a0 => 135
	i64 1001381392624924420, ; 19: Microsoft.AspNetCore.Authentication.Core.dll => 0xde59f1230183704 => 15
	i64 1120440138749646132, ; 20: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 120
	i64 1315114680217950157, ; 21: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 68
	i64 1425944114962822056, ; 22: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 11
	i64 1624659445732251991, ; 23: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 66
	i64 1628611045998245443, ; 24: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 94
	i64 1636321030536304333, ; 25: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 87
	i64 1731380447121279447, ; 26: Newtonsoft.Json => 0x18071957e9b889d7 => 48
	i64 1743969030606105336, ; 27: System.Memory.dll => 0x1833d297e88f2af8 => 54
	i64 1795316252682057001, ; 28: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 67
	i64 1825687700144851180, ; 29: System.Runtime.InteropServices.RuntimeInformation.dll => 0x1956254a55ef08ec => 133
	i64 1836611346387731153, ; 30: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 105
	i64 1875917498431009007, ; 31: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 64
	i64 1981742497975770890, ; 32: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 93
	i64 2040001226662520565, ; 33: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 60
	i64 2133195048986300728, ; 34: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 48
	i64 2136356949452311481, ; 35: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 98
	i64 2165725771938924357, ; 36: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 71
	i64 2262844636196693701, ; 37: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 82
	i64 2284400282711631002, ; 38: System.Web.Services => 0x1fb3d1f42fd4249a => 129
	i64 2287887973817120656, ; 39: System.ComponentModel.DataAnnotations.dll => 0x1fc035fd8d41f790 => 132
	i64 2315304989185124968, ; 40: System.IO.FileSystem.dll => 0x20219d9ee311aa68 => 4
	i64 2329709569556905518, ; 41: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 90
	i64 2335503487726329082, ; 42: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 59
	i64 2337758774805907496, ; 43: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 57
	i64 2470498323731680442, ; 44: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 77
	i64 2479423007379663237, ; 45: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 110
	i64 2497223385847772520, ; 46: System.Runtime => 0x22a7eb7046413568 => 58
	i64 2547086958574651984, ; 47: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 63
	i64 2592350477072141967, ; 48: System.Xml.dll => 0x23f9e10627330e8f => 61
	i64 2624866290265602282, ; 49: mscorlib.dll => 0x246d65fbde2db8ea => 47
	i64 2656907746661064104, ; 50: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 34
	i64 2694427813909235223, ; 51: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 102
	i64 2783046991838674048, ; 52: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 57
	i64 2960931600190307745, ; 53: Xamarin.Forms.Core => 0x2917579a49927da1 => 116
	i64 3017704767998173186, ; 54: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 120
	i64 3021884968805928991, ; 55: Microsoft.AspNetCore.Authorization.Policy => 0x29efe45e55c5101f => 17
	i64 3168817962471953758, ; 56: Microsoft.Extensions.Hosting.Abstractions.dll => 0x2bf9e725d304955e => 38
	i64 3266690593535380875, ; 57: Microsoft.AspNetCore.Authorization => 0x2d559dc982c94d8b => 16
	i64 3289520064315143713, ; 58: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 89
	i64 3303437397778967116, ; 59: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 65
	i64 3311221304742556517, ; 60: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 56
	i64 3396143930648122816, ; 61: Microsoft.Extensions.FileProviders.Abstractions => 0x2f2186e9506155c0 => 37
	i64 3493805808809882663, ; 62: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 108
	i64 3522470458906976663, ; 63: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 107
	i64 3531994851595924923, ; 64: System.Numerics => 0x31042a9aade235bb => 55
	i64 3571415421602489686, ; 65: System.Runtime.dll => 0x319037675df7e556 => 58
	i64 3638003163729360188, ; 66: Microsoft.Extensions.Configuration.Abstractions => 0x327cc89a39d5f53c => 32
	i64 3716579019761409177, ; 67: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 68: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 104
	i64 3772598417116884899, ; 69: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 83
	i64 3966267475168208030, ; 70: System.Memory => 0x370b03412596249e => 54
	i64 4225924121207573736, ; 71: Microsoft.AspNetCore.Authentication.Abstractions => 0x3aa57f992c550ce8 => 14
	i64 4243591448627561453, ; 72: Microsoft.AspNetCore.Http.Extensions.dll => 0x3ae443f06354c3ed => 22
	i64 4250192876909962317, ; 73: Microsoft.AspNetCore.Hosting.Abstractions => 0x3afbb7e72f1d244d => 18
	i64 4525561845656915374, ; 74: System.ServiceModel.Internals => 0x3ece06856b710dae => 130
	i64 4636684751163556186, ; 75: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 112
	i64 4743821336939966868, ; 76: System.ComponentModel.Annotations => 0x41d5705f4239b194 => 131
	i64 4782108999019072045, ; 77: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 70
	i64 4794310189461587505, ; 78: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 63
	i64 4795410492532947900, ; 79: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 107
	i64 5112836352847824253, ; 80: Microsoft.AspNetCore.WebUtilities.dll => 0x46f47192ee32c57d => 30
	i64 5142919913060024034, ; 81: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 117
	i64 5177565741364132164, ; 82: Microsoft.AspNetCore.Http => 0x47da689c1f3db944 => 21
	i64 5203618020066742981, ; 83: Xamarin.Essentials => 0x4836f704f0e652c5 => 115
	i64 5205316157927637098, ; 84: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 96
	i64 5348796042099802469, ; 85: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 97
	i64 5376510917114486089, ; 86: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 110
	i64 5408338804355907810, ; 87: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 109
	i64 5423376490970181369, ; 88: System.Runtime.InteropServices.RuntimeInformation => 0x4b43b42f2b7b6ef9 => 133
	i64 5451019430259338467, ; 89: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 76
	i64 5507995362134886206, ; 90: System.Core.dll => 0x4c705499688c873e => 51
	i64 5527431512186326818, ; 91: System.IO.FileSystem.Primitives.dll => 0x4cb561acbc2a8f22 => 9
	i64 5593115988096097561, ; 92: Microsoft.AspNetCore.Routing.dll => 0x4d9ebd5b8a069d19 => 29
	i64 5610815111739789596, ; 93: Microsoft.AspNetCore.Authentication.Core => 0x4ddd9e9de3a4d11c => 15
	i64 5692067934154308417, ; 94: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 114
	i64 5741990095351817038, ; 95: Microsoft.Extensions.Localization.Abstractions.dll => 0x4fafa591c141a34e => 39
	i64 5757522595884336624, ; 96: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 74
	i64 5814345312393086621, ; 97: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 102
	i64 5896680224035167651, ; 98: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 91
	i64 6085203216496545422, ; 99: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 118
	i64 6086316965293125504, ; 100: FormsViewGroup.dll => 0x5476f10882baef80 => 12
	i64 6319713645133255417, ; 101: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 92
	i64 6401687960814735282, ; 102: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 90
	i64 6504860066809920875, ; 103: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 71
	i64 6548213210057960872, ; 104: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 80
	i64 6560151584539558821, ; 105: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 43
	i64 6591024623626361694, ; 106: System.Web.Services.dll => 0x5b7805f9751a1b5e => 129
	i64 6659513131007730089, ; 107: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 86
	i64 6876862101832370452, ; 108: System.Xml.Linq => 0x5f6f85a57d108914 => 62
	i64 6894844156784520562, ; 109: System.Numerics.Vectors => 0x5faf683aead1ad72 => 56
	i64 6911788284027924527, ; 110: Microsoft.AspNetCore.Hosting.Server.Abstractions => 0x5feb9ad2f830f02f => 19
	i64 7036436454368433159, ; 111: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 88
	i64 7103753931438454322, ; 112: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 85
	i64 7112547816752919026, ; 113: System.IO.FileSystem => 0x62b4d88e3189b1f2 => 4
	i64 7270811800166795866, ; 114: System.Linq => 0x64e71ccf51a90a5a => 8
	i64 7331765743953618630, ; 115: Microsoft.AspNetCore.Http.dll => 0x65bfaa1948bba6c6 => 21
	i64 7338192458477945005, ; 116: System.Reflection => 0x65d67f295d0740ad => 6
	i64 7473077275758116397, ; 117: Microsoft.DotNet.PlatformAbstractions => 0x67b5b430309b3e2d => 31
	i64 7488575175965059935, ; 118: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 62
	i64 7635363394907363464, ; 119: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 116
	i64 7637365915383206639, ; 120: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 115
	i64 7654504624184590948, ; 121: System.Net.Http => 0x6a3a4366801b8264 => 10
	i64 7820441508502274321, ; 122: System.Data => 0x6c87ca1e14ff8111 => 122
	i64 7824823231109474690, ; 123: Microsoft.AspNetCore.Authorization.Policy.dll => 0x6c975b4560812982 => 17
	i64 7836164640616011524, ; 124: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 66
	i64 7919757340696389605, ; 125: Microsoft.Extensions.Diagnostics.Abstractions => 0x6de8a157378027e5 => 36
	i64 8044118961405839122, ; 126: System.ComponentModel.Composition => 0x6fa2739369944712 => 128
	i64 8064050204834738623, ; 127: System.Collections.dll => 0x6fe942efa61731bf => 5
	i64 8083354569033831015, ; 128: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 89
	i64 8087206902342787202, ; 129: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 52
	i64 8103644804370223335, ; 130: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 124
	i64 8167236081217502503, ; 131: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 13
	i64 8185542183669246576, ; 132: System.Collections => 0x7198e33f4794aa70 => 5
	i64 8225843963075019979, ; 133: SeenIT.dll => 0x7228118084e0c4cb => 49
	i64 8290740647658429042, ; 134: System.Runtime.Extensions => 0x730ea0b15c929a72 => 3
	i64 8318905602908530212, ; 135: System.ComponentModel.DataAnnotations => 0x7372b092055ea624 => 132
	i64 8398329775253868912, ; 136: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 75
	i64 8400357532724379117, ; 137: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 101
	i64 8519205576476231015, ; 138: Microsoft.AspNetCore.Mvc.Core.dll => 0x763a4c55ca648567 => 25
	i64 8601935802264776013, ; 139: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 109
	i64 8611142787134128904, ; 140: Microsoft.AspNetCore.Hosting.Server.Abstractions.dll => 0x7780ecbdb94c0308 => 19
	i64 8626175481042262068, ; 141: Java.Interop => 0x77b654e585b55834 => 13
	i64 8639588376636138208, ; 142: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 100
	i64 8684531736582871431, ; 143: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 127
	i64 8725526185868997716, ; 144: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 52
	i64 9226226475190220305, ; 145: SeenIT.Android => 0x800a2418b7047611 => 0
	i64 9312692141327339315, ; 146: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 114
	i64 9324707631942237306, ; 147: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 67
	i64 9413000421947348542, ; 148: Microsoft.AspNetCore.Hosting.Abstractions.dll => 0x82a1b202f4c6163e => 18
	i64 9584643793929893533, ; 149: System.IO.dll => 0x85037ebfbbd7f69d => 7
	i64 9662334977499516867, ; 150: System.Numerics.dll => 0x8617827802b0cfc3 => 55
	i64 9678050649315576968, ; 151: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 77
	i64 9711637524876806384, ; 152: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 97
	i64 9808709177481450983, ; 153: Mono.Android.dll => 0x881f890734e555e7 => 46
	i64 9825649861376906464, ; 154: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 74
	i64 9834056768316610435, ; 155: System.Transactions.dll => 0x8879968718899783 => 123
	i64 9938556199016768930, ; 156: Microsoft.AspNetCore.Routing => 0x89ecd834cea6a5a2 => 29
	i64 9998632235833408227, ; 157: Mono.Security => 0x8ac2470b209ebae3 => 135
	i64 10038780035334861115, ; 158: System.Net.Http.dll => 0x8b50e941206af13b => 10
	i64 10229024438826829339, ; 159: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 80
	i64 10243523786148452761, ; 160: Microsoft.AspNetCore.Http.Abstractions => 0x8e284e9c69a49999 => 20
	i64 10376576884623852283, ; 161: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 108
	i64 10430153318873392755, ; 162: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 78
	i64 10458986597687352396, ; 163: Microsoft.AspNetCore.Routing.Abstractions => 0x9125c8e581b9dc4c => 28
	i64 10714184849103829812, ; 164: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 3
	i64 10847732767863316357, ; 165: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 68
	i64 11002576679268595294, ; 166: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 41
	i64 11023048688141570732, ; 167: System.Core => 0x98f9bc61168392ac => 51
	i64 11037814507248023548, ; 168: System.Xml => 0x992e31d0412bf7fc => 61
	i64 11050168729868392624, ; 169: Microsoft.AspNetCore.Http.Features => 0x995a15e9dbef58b0 => 23
	i64 11162124722117608902, ; 170: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 113
	i64 11226290749488709958, ; 171: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 43
	i64 11340910727871153756, ; 172: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 79
	i64 11392833485892708388, ; 173: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 103
	i64 11432101114902388181, ; 174: System.AppContext => 0x9ea6fb64e61a9dd5 => 2
	i64 11485890710487134646, ; 175: System.Runtime.InteropServices => 0x9f6614bf0f8b71b6 => 134
	i64 11529969570048099689, ; 176: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 113
	i64 11578238080964724296, ; 177: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 88
	i64 11580057168383206117, ; 178: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 64
	i64 11597940890313164233, ; 179: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 180: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 85
	i64 12102847907131387746, ; 181: System.Buffers => 0xa7f5f40c43256f62 => 50
	i64 12137774235383566651, ; 182: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 111
	i64 12310909314810916455, ; 183: Microsoft.Extensions.Localization.dll => 0xaad922cbbb5a2e67 => 40
	i64 12441092376399691269, ; 184: Microsoft.AspNetCore.Authentication.Abstractions.dll => 0xaca7a399c11fbe05 => 14
	i64 12451044538927396471, ; 185: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 84
	i64 12466513435562512481, ; 186: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 95
	i64 12487638416075308985, ; 187: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 81
	i64 12538491095302438457, ; 188: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 72
	i64 12550732019250633519, ; 189: System.IO.Compression => 0xae2d28465e8e1b2f => 126
	i64 12700543734426720211, ; 190: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 73
	i64 12708238894395270091, ; 191: System.IO => 0xb05cbbf17d3ba3cb => 7
	i64 12843321153144804894, ; 192: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 44
	i64 12843770487262409629, ; 193: System.AppContext.dll => 0xb23e3d357debf39d => 2
	i64 12870522969378281911, ; 194: SeenIT.Android.dll => 0xb29d48731f4c59b7 => 0
	i64 12963446364377008305, ; 195: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 125
	i64 13308002692117796025, ; 196: Microsoft.AspNetCore.Routing.Abstractions.dll => 0xb8af85f08d9f94b9 => 28
	i64 13370592475155966277, ; 197: System.Runtime.Serialization => 0xb98de304062ea945 => 11
	i64 13401370062847626945, ; 198: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 111
	i64 13404347523447273790, ; 199: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 75
	i64 13404984788036896679, ; 200: Microsoft.AspNetCore.Http.Abstractions.dll => 0xba0812a45e7447a7 => 20
	i64 13454009404024712428, ; 201: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 121
	i64 13491513212026656886, ; 202: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 69
	i64 13550417756503177631, ; 203: Microsoft.Extensions.FileProviders.Abstractions.dll => 0xbc0cc1280684799f => 37
	i64 13572454107664307259, ; 204: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 104
	i64 13618112415141049676, ; 205: Microsoft.AspNetCore.Mvc.Core => 0xbcfd4116f7d1b54c => 25
	i64 13647894001087880694, ; 206: System.Data.dll => 0xbd670f48cb071df6 => 122
	i64 13921917134693230900, ; 207: Microsoft.AspNetCore.WebUtilities => 0xc13495df5dd06934 => 30
	i64 13955418299340266673, ; 208: Microsoft.Extensions.DependencyModel.dll => 0xc1ab9b0118299cb1 => 35
	i64 13959074834287824816, ; 209: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 84
	i64 13967638549803255703, ; 210: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 117
	i64 14124974489674258913, ; 211: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 72
	i64 14172845254133543601, ; 212: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 98
	i64 14261073672896646636, ; 213: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 103
	i64 14261232074598307362, ; 214: Microsoft.AspNetCore.Mvc.Abstractions => 0xc5ea130339d6d622 => 24
	i64 14327695147300244862, ; 215: System.Reflection.dll => 0xc6d632d338eb4d7e => 6
	i64 14486659737292545672, ; 216: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 91
	i64 14528548208938697926, ; 217: Microsoft.AspNetCore.Mvc.Abstractions.dll => 0xc99fc59ed7edc4c6 => 24
	i64 14551742072151931844, ; 218: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 59
	i64 14644440854989303794, ; 219: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 96
	i64 14669215534098758659, ; 220: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 34
	i64 14792063746108907174, ; 221: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 121
	i64 14852515768018889994, ; 222: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 79
	i64 14954917835170835695, ; 223: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 33
	i64 14987728460634540364, ; 224: System.IO.Compression.dll => 0xcfff1ba06622494c => 126
	i64 14988210264188246988, ; 225: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 81
	i64 15051741671811457419, ; 226: Microsoft.Extensions.Diagnostics.Abstractions.dll => 0xd0e2874d8f44218b => 36
	i64 15133485256822086103, ; 227: System.Linq.dll => 0xd204f0a9127dd9d7 => 8
	i64 15227001540531775957, ; 228: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd3512d3999b8e9d5 => 32
	i64 15332518387094693223, ; 229: Microsoft.AspNetCore.Mvc.DataAnnotations.dll => 0xd4c80c3ce6eca567 => 26
	i64 15370028218478381000, ; 230: Microsoft.Extensions.Localization.Abstractions => 0xd54d4f3b162247c8 => 39
	i64 15370334346939861994, ; 231: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 78
	i64 15391712275433856905, ; 232: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 33
	i64 15565247197164990907, ; 233: Microsoft.AspNetCore.Http.Extensions => 0xd802dddb8c29f1bb => 22
	i64 15582737692548360875, ; 234: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 94
	i64 15592226634512578529, ; 235: Microsoft.AspNetCore.Authorization.dll => 0xd862b7834f81b7e1 => 16
	i64 15609085926864131306, ; 236: System.dll => 0xd89e9cf3334914ea => 53
	i64 15620595871140898079, ; 237: Microsoft.Extensions.DependencyModel => 0xd8c7812eef49651f => 35
	i64 15735700225633954557, ; 238: Microsoft.Extensions.Localization => 0xda606ffbe0f22afd => 40
	i64 15755368083429170162, ; 239: System.IO.FileSystem.Primitives => 0xdaa64fcbde529bf2 => 9
	i64 15777549416145007739, ; 240: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 106
	i64 15810740023422282496, ; 241: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 119
	i64 15852824340364052161, ; 242: Microsoft.AspNetCore.Http.Features.dll => 0xdc008bbee610c6c1 => 23
	i64 15963349826457351533, ; 243: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 60
	i64 16046481083542319511, ; 244: Microsoft.Extensions.ObjectPool => 0xdeb08d870f90b197 => 42
	i64 16154507427712707110, ; 245: System => 0xe03056ea4e39aa26 => 53
	i64 16321164108206115771, ; 246: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 41
	i64 16344871930018146979, ; 247: Microsoft.AspNetCore.ResponseCaching.Abstractions => 0xe2d4a66be7fc2aa3 => 27
	i64 16565028646146589191, ; 248: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 128
	i64 16621146507174665210, ; 249: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 76
	i64 16677317093839702854, ; 250: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 101
	i64 16822611501064131242, ; 251: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 124
	i64 16833383113903931215, ; 252: mscorlib => 0xe99c30c1484d7f4f => 47
	i64 17024911836938395553, ; 253: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 65
	i64 17031351772568316411, ; 254: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 99
	i64 17037200463775726619, ; 255: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 87
	i64 17126545051278881272, ; 256: Microsoft.Net.Http.Headers.dll => 0xedadb5fbdb33b1f8 => 45
	i64 17187273293601214786, ; 257: System.ComponentModel.Annotations.dll => 0xee8575ff9aa89142 => 131
	i64 17544493274320527064, ; 258: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 70
	i64 17704177640604968747, ; 259: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 95
	i64 17710060891934109755, ; 260: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 93
	i64 17712670374920797664, ; 261: System.Runtime.InteropServices.dll => 0xf5d00bdc38bd3de0 => 134
	i64 17838668724098252521, ; 262: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 50
	i64 17882897186074144999, ; 263: FormsViewGroup => 0xf82cd03e3ac830e7 => 12
	i64 17892495832318972303, ; 264: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 119
	i64 17911643751311784505, ; 265: Microsoft.Net.Http.Headers => 0xf892f1178448ba39 => 45
	i64 17928294245072900555, ; 266: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 127
	i64 18116111925905154859, ; 267: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 69
	i64 18121036031235206392, ; 268: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 99
	i64 18129453464017766560, ; 269: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 130
	i64 18305135509493619199, ; 270: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 100
	i64 18380184030268848184 ; 271: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 112
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [272 x i32] [
	i32 31, i32 83, i32 44, i32 46, i32 38, i32 73, i32 105, i32 106, ; 0..7
	i32 42, i32 92, i32 125, i32 86, i32 26, i32 82, i32 49, i32 123, ; 8..15
	i32 27, i32 118, i32 135, i32 15, i32 120, i32 68, i32 11, i32 66, ; 16..23
	i32 94, i32 87, i32 48, i32 54, i32 67, i32 133, i32 105, i32 64, ; 24..31
	i32 93, i32 60, i32 48, i32 98, i32 71, i32 82, i32 129, i32 132, ; 32..39
	i32 4, i32 90, i32 59, i32 57, i32 77, i32 110, i32 58, i32 63, ; 40..47
	i32 61, i32 47, i32 34, i32 102, i32 57, i32 116, i32 120, i32 17, ; 48..55
	i32 38, i32 16, i32 89, i32 65, i32 56, i32 37, i32 108, i32 107, ; 56..63
	i32 55, i32 58, i32 32, i32 1, i32 104, i32 83, i32 54, i32 14, ; 64..71
	i32 22, i32 18, i32 130, i32 112, i32 131, i32 70, i32 63, i32 107, ; 72..79
	i32 30, i32 117, i32 21, i32 115, i32 96, i32 97, i32 110, i32 109, ; 80..87
	i32 133, i32 76, i32 51, i32 9, i32 29, i32 15, i32 114, i32 39, ; 88..95
	i32 74, i32 102, i32 91, i32 118, i32 12, i32 92, i32 90, i32 71, ; 96..103
	i32 80, i32 43, i32 129, i32 86, i32 62, i32 56, i32 19, i32 88, ; 104..111
	i32 85, i32 4, i32 8, i32 21, i32 6, i32 31, i32 62, i32 116, ; 112..119
	i32 115, i32 10, i32 122, i32 17, i32 66, i32 36, i32 128, i32 5, ; 120..127
	i32 89, i32 52, i32 124, i32 13, i32 5, i32 49, i32 3, i32 132, ; 128..135
	i32 75, i32 101, i32 25, i32 109, i32 19, i32 13, i32 100, i32 127, ; 136..143
	i32 52, i32 0, i32 114, i32 67, i32 18, i32 7, i32 55, i32 77, ; 144..151
	i32 97, i32 46, i32 74, i32 123, i32 29, i32 135, i32 10, i32 80, ; 152..159
	i32 20, i32 108, i32 78, i32 28, i32 3, i32 68, i32 41, i32 51, ; 160..167
	i32 61, i32 23, i32 113, i32 43, i32 79, i32 103, i32 2, i32 134, ; 168..175
	i32 113, i32 88, i32 64, i32 1, i32 85, i32 50, i32 111, i32 40, ; 176..183
	i32 14, i32 84, i32 95, i32 81, i32 72, i32 126, i32 73, i32 7, ; 184..191
	i32 44, i32 2, i32 0, i32 125, i32 28, i32 11, i32 111, i32 75, ; 192..199
	i32 20, i32 121, i32 69, i32 37, i32 104, i32 25, i32 122, i32 30, ; 200..207
	i32 35, i32 84, i32 117, i32 72, i32 98, i32 103, i32 24, i32 6, ; 208..215
	i32 91, i32 24, i32 59, i32 96, i32 34, i32 121, i32 79, i32 33, ; 216..223
	i32 126, i32 81, i32 36, i32 8, i32 32, i32 26, i32 39, i32 78, ; 224..231
	i32 33, i32 22, i32 94, i32 16, i32 53, i32 35, i32 40, i32 9, ; 232..239
	i32 106, i32 119, i32 23, i32 60, i32 42, i32 53, i32 41, i32 27, ; 240..247
	i32 128, i32 76, i32 101, i32 124, i32 47, i32 65, i32 99, i32 87, ; 248..255
	i32 45, i32 131, i32 70, i32 95, i32 93, i32 134, i32 50, i32 12, ; 256..263
	i32 119, i32 45, i32 127, i32 69, i32 99, i32 130, i32 100, i32 112 ; 272..271
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
