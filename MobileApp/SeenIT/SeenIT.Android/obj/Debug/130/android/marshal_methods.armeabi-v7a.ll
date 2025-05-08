; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [272 x i32] [
	i32 26230656, ; 0: Microsoft.Extensions.DependencyModel => 0x1903f80 => 35
	i32 32687329, ; 1: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 92
	i32 34715100, ; 2: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 121
	i32 39109920, ; 3: Newtonsoft.Json.dll => 0x254c520 => 48
	i32 57263871, ; 4: Xamarin.Forms.Core.dll => 0x369c6ff => 116
	i32 98325684, ; 5: Microsoft.Extensions.Diagnostics.Abstractions => 0x5dc54b4 => 36
	i32 101534019, ; 6: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 106
	i32 117431740, ; 7: System.Runtime.InteropServices => 0x6ffddbc => 134
	i32 120558881, ; 8: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 106
	i32 159306688, ; 9: System.ComponentModel.Annotations => 0x97ed3c0 => 131
	i32 165246403, ; 10: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 73
	i32 176714968, ; 11: Microsoft.AspNetCore.WebUtilities.dll => 0xa8874d8 => 30
	i32 182336117, ; 12: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 107
	i32 209399409, ; 13: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 71
	i32 230216969, ; 14: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 87
	i32 232815796, ; 15: System.Web.Services => 0xde07cb4 => 129
	i32 261689757, ; 16: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 76
	i32 278686392, ; 17: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 91
	i32 280482487, ; 18: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 85
	i32 300686228, ; 19: Microsoft.AspNetCore.Authentication.Abstractions.dll => 0x11ec1b94 => 14
	i32 318968648, ; 20: Xamarin.AndroidX.Activity.dll => 0x13031348 => 63
	i32 321597661, ; 21: System.Numerics => 0x132b30dd => 55
	i32 338324308, ; 22: Microsoft.AspNetCore.Mvc.DataAnnotations.dll => 0x142a6b54 => 26
	i32 342366114, ; 23: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 89
	i32 344827588, ; 24: Microsoft.AspNetCore.ResponseCaching.Abstractions => 0x148da6c4 => 27
	i32 384051609, ; 25: Microsoft.AspNetCore.Routing.dll => 0x16e42999 => 29
	i32 385762202, ; 26: System.Memory.dll => 0x16fe439a => 54
	i32 441335492, ; 27: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 75
	i32 442521989, ; 28: Xamarin.Essentials => 0x1a605985 => 115
	i32 442565967, ; 29: System.Collections => 0x1a61054f => 5
	i32 450948140, ; 30: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 84
	i32 465846621, ; 31: mscorlib => 0x1bc4415d => 47
	i32 469710990, ; 32: System.dll => 0x1bff388e => 53
	i32 476646585, ; 33: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 85
	i32 486930444, ; 34: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 96
	i32 490002678, ; 35: Microsoft.AspNetCore.Hosting.Server.Abstractions.dll => 0x1d34d8f6 => 19
	i32 513247710, ; 36: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 44
	i32 526420162, ; 37: System.Transactions.dll => 0x1f6088c2 => 123
	i32 540030774, ; 38: System.IO.FileSystem.dll => 0x20303736 => 4
	i32 545304856, ; 39: System.Runtime.Extensions => 0x2080b118 => 3
	i32 605376203, ; 40: System.IO.Compression.FileSystem => 0x24154ecb => 127
	i32 627609679, ; 41: Xamarin.AndroidX.CustomView => 0x2568904f => 80
	i32 662205335, ; 42: System.Text.Encodings.Web.dll => 0x27787397 => 59
	i32 663517072, ; 43: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 112
	i32 666292255, ; 44: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 68
	i32 690569205, ; 45: System.Xml.Linq.dll => 0x29293ff5 => 62
	i32 724146010, ; 46: Microsoft.AspNetCore.Authorization.Policy.dll => 0x2b29975a => 17
	i32 775507847, ; 47: System.IO.Compression => 0x2e394f87 => 126
	i32 789151979, ; 48: Microsoft.Extensions.Options => 0x2f0980eb => 43
	i32 809851609, ; 49: System.Drawing.Common.dll => 0x30455ad9 => 125
	i32 843511501, ; 50: Xamarin.AndroidX.Print => 0x3246f6cd => 103
	i32 922222539, ; 51: SeenIT.Android.dll => 0x36f7ffcb => 0
	i32 928116545, ; 52: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 121
	i32 955402788, ; 53: Newtonsoft.Json => 0x38f24a24 => 48
	i32 967690846, ; 54: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 89
	i32 974778368, ; 55: FormsViewGroup.dll => 0x3a19f000 => 12
	i32 992768348, ; 56: System.Collections.dll => 0x3b2c715c => 5
	i32 994442037, ; 57: System.IO.FileSystem => 0x3b45fb35 => 4
	i32 1012816738, ; 58: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 105
	i32 1028951442, ; 59: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 33
	i32 1035644815, ; 60: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 67
	i32 1042160112, ; 61: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 118
	i32 1048992957, ; 62: Microsoft.Extensions.Diagnostics.Abstractions.dll => 0x3e865cbd => 36
	i32 1052210849, ; 63: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 93
	i32 1098259244, ; 64: System => 0x41761b2c => 53
	i32 1099692271, ; 65: Microsoft.DotNet.PlatformAbstractions => 0x418bf8ef => 31
	i32 1110309514, ; 66: Microsoft.Extensions.Hosting.Abstractions => 0x422dfa8a => 38
	i32 1112354281, ; 67: Microsoft.AspNetCore.Authentication.Abstractions => 0x424d2de9 => 14
	i32 1173126369, ; 68: Microsoft.Extensions.FileProviders.Abstractions.dll => 0x45ec7ce1 => 37
	i32 1175144683, ; 69: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 110
	i32 1178241025, ; 70: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 100
	i32 1204270330, ; 71: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 68
	i32 1220193633, ; 72: Microsoft.Net.Http.Headers => 0x48baad61 => 45
	i32 1236289705, ; 73: Microsoft.AspNetCore.Hosting.Server.Abstractions => 0x49b048a9 => 19
	i32 1267360935, ; 74: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 111
	i32 1267908789, ; 75: Microsoft.AspNetCore.Routing => 0x4b92c0b5 => 29
	i32 1293217323, ; 76: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 82
	i32 1324164729, ; 77: System.Linq => 0x4eed2679 => 8
	i32 1364015309, ; 78: System.IO => 0x514d38cd => 7
	i32 1365406463, ; 79: System.ServiceModel.Internals.dll => 0x516272ff => 130
	i32 1376866003, ; 80: Xamarin.AndroidX.SavedState => 0x52114ed3 => 105
	i32 1395857551, ; 81: Xamarin.AndroidX.Media.dll => 0x5333188f => 97
	i32 1406073936, ; 82: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 77
	i32 1411638395, ; 83: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 57
	i32 1457743152, ; 84: System.Runtime.Extensions.dll => 0x56e36530 => 3
	i32 1460219004, ; 85: Xamarin.Forms.Xaml => 0x57092c7c => 119
	i32 1462112819, ; 86: System.IO.Compression.dll => 0x57261233 => 126
	i32 1469204771, ; 87: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 66
	i32 1470490898, ; 88: Microsoft.Extensions.Primitives => 0x57a5e912 => 44
	i32 1565862583, ; 89: System.IO.FileSystem.Primitives => 0x5d552ab7 => 9
	i32 1582372066, ; 90: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 81
	i32 1592978981, ; 91: System.Runtime.Serialization.dll => 0x5ef2ee25 => 11
	i32 1622152042, ; 92: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 95
	i32 1624863272, ; 93: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 114
	i32 1636350590, ; 94: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 79
	i32 1639515021, ; 95: System.Net.Http.dll => 0x61b9038d => 10
	i32 1657153582, ; 96: System.Runtime => 0x62c6282e => 58
	i32 1658241508, ; 97: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 108
	i32 1658251792, ; 98: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 120
	i32 1670060433, ; 99: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 76
	i32 1726116996, ; 100: System.Reflection.dll => 0x66e27484 => 6
	i32 1726181967, ; 101: SeenIT.dll => 0x66e3724f => 49
	i32 1729485958, ; 102: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 72
	i32 1766324549, ; 103: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 107
	i32 1776026572, ; 104: System.Core.dll => 0x69dc03cc => 51
	i32 1788241197, ; 105: Xamarin.AndroidX.Fragment => 0x6a96652d => 84
	i32 1808609942, ; 106: Xamarin.AndroidX.Loader => 0x6bcd3296 => 95
	i32 1813201214, ; 107: Xamarin.Google.Android.Material => 0x6c13413e => 120
	i32 1818569960, ; 108: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 101
	i32 1819327070, ; 109: Microsoft.AspNetCore.Http.Features.dll => 0x6c70ba5e => 23
	i32 1828688058, ; 110: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 41
	i32 1867746548, ; 111: Xamarin.Essentials.dll => 0x6f538cf4 => 115
	i32 1878053835, ; 112: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 119
	i32 1885316902, ; 113: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 69
	i32 1894524299, ; 114: Microsoft.DotNet.PlatformAbstractions.dll => 0x70ec258b => 31
	i32 1919157823, ; 115: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 98
	i32 1928288591, ; 116: Microsoft.AspNetCore.Http.Abstractions => 0x72ef594f => 20
	i32 2011961780, ; 117: System.Buffers.dll => 0x77ec19b4 => 50
	i32 2019465201, ; 118: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 93
	i32 2055257422, ; 119: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 90
	i32 2075706075, ; 120: Microsoft.AspNetCore.Http.Abstractions.dll => 0x7bb8c2db => 20
	i32 2079903147, ; 121: System.Runtime.dll => 0x7bf8cdab => 58
	i32 2090596640, ; 122: System.Numerics.Vectors => 0x7c9bf920 => 56
	i32 2097448633, ; 123: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 86
	i32 2126786730, ; 124: Xamarin.Forms.Platform.Android => 0x7ec430aa => 117
	i32 2181898931, ; 125: Microsoft.Extensions.Options.dll => 0x820d22b3 => 43
	i32 2182738860, ; 126: Microsoft.AspNetCore.Mvc.Core.dll => 0x8219f3ac => 25
	i32 2192057212, ; 127: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 41
	i32 2197979891, ; 128: Microsoft.Extensions.DependencyModel.dll => 0x830282f3 => 35
	i32 2201231467, ; 129: System.Net.Http => 0x8334206b => 10
	i32 2204417087, ; 130: Microsoft.Extensions.ObjectPool => 0x8364bc3f => 42
	i32 2217644978, ; 131: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 110
	i32 2242871324, ; 132: Microsoft.AspNetCore.Http.dll => 0x85af801c => 21
	i32 2244775296, ; 133: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 96
	i32 2256548716, ; 134: Xamarin.AndroidX.MultiDex => 0x8680336c => 98
	i32 2261435625, ; 135: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 88
	i32 2266799131, ; 136: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 32
	i32 2279755925, ; 137: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 104
	i32 2285293097, ; 138: Microsoft.AspNetCore.Mvc.Abstractions => 0x8836ce29 => 24
	i32 2315684594, ; 139: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 64
	i32 2321784778, ; 140: Microsoft.AspNetCore.Mvc.Abstractions.dll => 0x8a639fca => 24
	i32 2340441535, ; 141: System.Runtime.InteropServices.RuntimeInformation.dll => 0x8b804dbf => 133
	i32 2409053734, ; 142: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 102
	i32 2435904999, ; 143: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 132
	i32 2458592288, ; 144: Microsoft.AspNetCore.Authentication.Core => 0x928b2420 => 15
	i32 2465532216, ; 145: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 75
	i32 2471841756, ; 146: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 147: Java.Interop.dll => 0x93918882 => 13
	i32 2490993605, ; 148: System.AppContext.dll => 0x94798bc5 => 2
	i32 2501346920, ; 149: System.Data.DataSetExtensions => 0x95178668 => 124
	i32 2505896520, ; 150: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 92
	i32 2537015816, ; 151: Microsoft.AspNetCore.Authorization => 0x9737ca08 => 16
	i32 2570120770, ; 152: System.Text.Encodings.Web => 0x9930ee42 => 59
	i32 2581819634, ; 153: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 111
	i32 2592341985, ; 154: Microsoft.Extensions.FileProviders.Abstractions => 0x9a83ffe1 => 37
	i32 2593268061, ; 155: Microsoft.AspNetCore.Routing.Abstractions.dll => 0x9a92215d => 28
	i32 2594125473, ; 156: Microsoft.AspNetCore.Hosting.Abstractions => 0x9a9f36a1 => 18
	i32 2620871830, ; 157: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 79
	i32 2624644809, ; 158: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 83
	i32 2633051222, ; 159: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 91
	i32 2633959305, ; 160: Microsoft.AspNetCore.Http.Extensions.dll => 0x9cff0789 => 22
	i32 2693849962, ; 161: System.IO.dll => 0xa090e36a => 7
	i32 2701096212, ; 162: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 108
	i32 2732626843, ; 163: Xamarin.AndroidX.Activity => 0xa2e0939b => 63
	i32 2735631878, ; 164: Microsoft.AspNetCore.Authorization.dll => 0xa30e6e06 => 16
	i32 2737747696, ; 165: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 66
	i32 2766581644, ; 166: Xamarin.Forms.Core => 0xa4e6af8c => 116
	i32 2778768386, ; 167: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 113
	i32 2810250172, ; 168: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 77
	i32 2819470561, ; 169: System.Xml.dll => 0xa80db4e1 => 61
	i32 2850549256, ; 170: Microsoft.AspNetCore.Http.Features => 0xa9e7ee08 => 23
	i32 2853208004, ; 171: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 113
	i32 2855708567, ; 172: Xamarin.AndroidX.Transition => 0xaa36a797 => 109
	i32 2901442782, ; 173: System.Reflection => 0xacf080de => 6
	i32 2903344695, ; 174: System.ComponentModel.Composition => 0xad0d8637 => 128
	i32 2905242038, ; 175: mscorlib.dll => 0xad2a79b6 => 47
	i32 2916838712, ; 176: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 114
	i32 2919462931, ; 177: System.Numerics.Vectors.dll => 0xae037813 => 56
	i32 2921128767, ; 178: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 65
	i32 2978368250, ; 179: Microsoft.AspNetCore.Hosting.Abstractions.dll => 0xb1864afa => 18
	i32 2978675010, ; 180: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 82
	i32 2996646946, ; 181: Microsoft.AspNetCore.Http => 0xb29d3422 => 21
	i32 3024354802, ; 182: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 87
	i32 3033331042, ; 183: Microsoft.AspNetCore.Authentication.Core.dll => 0xb4ccf562 => 15
	i32 3036999524, ; 184: Microsoft.AspNetCore.Http.Extensions => 0xb504ef64 => 22
	i32 3044182254, ; 185: FormsViewGroup => 0xb57288ee => 12
	i32 3057625584, ; 186: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 99
	i32 3111772706, ; 187: System.Runtime.Serialization => 0xb979e222 => 11
	i32 3113762169, ; 188: Microsoft.AspNetCore.Routing.Abstractions => 0xb9983d79 => 28
	i32 3124832203, ; 189: System.Threading.Tasks.Extensions => 0xba4127cb => 60
	i32 3151576809, ; 190: Microsoft.AspNetCore.Mvc.Core => 0xbbd93ee9 => 25
	i32 3204380047, ; 191: System.Data.dll => 0xbefef58f => 122
	i32 3211777861, ; 192: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 81
	i32 3228018376, ; 193: Microsoft.AspNetCore.ResponseCaching.Abstractions.dll => 0xc067a6c8 => 27
	i32 3247949154, ; 194: Mono.Security => 0xc197c562 => 135
	i32 3258312781, ; 195: Xamarin.AndroidX.CardView => 0xc235e84d => 72
	i32 3265893370, ; 196: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 60
	i32 3267021929, ; 197: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 70
	i32 3280506390, ; 198: System.ComponentModel.Annotations.dll => 0xc3888e16 => 131
	i32 3300764913, ; 199: Microsoft.AspNetCore.WebUtilities => 0xc4bdacf1 => 30
	i32 3317135071, ; 200: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 80
	i32 3317144872, ; 201: System.Data => 0xc5b79d28 => 122
	i32 3340431453, ; 202: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 69
	i32 3346324047, ; 203: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 100
	i32 3353484488, ; 204: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 86
	i32 3362522851, ; 205: Xamarin.AndroidX.Core => 0xc86c06e3 => 78
	i32 3366347497, ; 206: Java.Interop => 0xc8a662e9 => 13
	i32 3374999561, ; 207: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 104
	i32 3395150330, ; 208: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 57
	i32 3404865022, ; 209: System.ServiceModel.Internals => 0xcaf21dfe => 130
	i32 3428513518, ; 210: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 34
	i32 3429136800, ; 211: System.Xml => 0xcc6479a0 => 61
	i32 3430777524, ; 212: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 213: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 83
	i32 3476120550, ; 214: Mono.Android => 0xcf3163e6 => 46
	i32 3486566296, ; 215: System.Transactions => 0xcfd0c798 => 123
	i32 3493954962, ; 216: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 74
	i32 3501239056, ; 217: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 70
	i32 3509114376, ; 218: System.Xml.Linq => 0xd128d608 => 62
	i32 3523908110, ; 219: SeenIT => 0xd20a920e => 49
	i32 3536029504, ; 220: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 117
	i32 3567349600, ; 221: System.ComponentModel.Composition.dll => 0xd4a16f60 => 128
	i32 3592435036, ; 222: Microsoft.Extensions.Localization.Abstractions => 0xd620355c => 39
	i32 3608519521, ; 223: System.Linq.dll => 0xd715a361 => 8
	i32 3618140916, ; 224: Xamarin.AndroidX.Preference => 0xd7a872f4 => 102
	i32 3624195450, ; 225: System.Runtime.InteropServices.RuntimeInformation => 0xd804d57a => 133
	i32 3627220390, ; 226: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 103
	i32 3632359727, ; 227: Xamarin.Forms.Platform => 0xd881692f => 118
	i32 3633644679, ; 228: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 65
	i32 3638274909, ; 229: System.IO.FileSystem.Primitives.dll => 0xd8dbab5d => 9
	i32 3641597786, ; 230: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 90
	i32 3645089577, ; 231: System.ComponentModel.DataAnnotations => 0xd943a729 => 132
	i32 3657292374, ; 232: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 32
	i32 3672681054, ; 233: Mono.Android.dll => 0xdae8aa5e => 46
	i32 3676310014, ; 234: System.Web.Services.dll => 0xdb2009fe => 129
	i32 3682565725, ; 235: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 71
	i32 3684561358, ; 236: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 74
	i32 3689375977, ; 237: System.Drawing.Common => 0xdbe768e9 => 125
	i32 3718780102, ; 238: Xamarin.AndroidX.Annotation => 0xdda814c6 => 64
	i32 3724971120, ; 239: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 99
	i32 3748608112, ; 240: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 52
	i32 3758932259, ; 241: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 88
	i32 3765508441, ; 242: Microsoft.Extensions.ObjectPool.dll => 0xe0711959 => 42
	i32 3776403777, ; 243: Microsoft.Extensions.Localization.Abstractions.dll => 0xe1175941 => 39
	i32 3786282454, ; 244: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 73
	i32 3822602673, ; 245: Xamarin.AndroidX.Media => 0xe3d849b1 => 97
	i32 3829621856, ; 246: System.Numerics.dll => 0xe4436460 => 55
	i32 3841636137, ; 247: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 33
	i32 3849253459, ; 248: System.Runtime.InteropServices.dll => 0xe56ef253 => 134
	i32 3885922214, ; 249: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 109
	i32 3896760992, ; 250: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 78
	i32 3898971068, ; 251: Microsoft.Extensions.Localization.dll => 0xe86593bc => 40
	i32 3920810846, ; 252: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 127
	i32 3921031405, ; 253: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 112
	i32 3931092270, ; 254: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 101
	i32 3945713374, ; 255: System.Data.DataSetExtensions.dll => 0xeb2ecede => 124
	i32 3954195687, ; 256: Microsoft.Extensions.Localization => 0xebb03ce7 => 40
	i32 3955647286, ; 257: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 67
	i32 4025784931, ; 258: System.Memory => 0xeff49a63 => 54
	i32 4044155772, ; 259: Microsoft.Net.Http.Headers.dll => 0xf10ceb7c => 45
	i32 4078967171, ; 260: Microsoft.Extensions.Hosting.Abstractions.dll => 0xf3201983 => 38
	i32 4105002889, ; 261: Mono.Security.dll => 0xf4ad5f89 => 135
	i32 4126470640, ; 262: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 34
	i32 4130442656, ; 263: System.AppContext => 0xf6318da0 => 2
	i32 4141580284, ; 264: Microsoft.AspNetCore.Authorization.Policy => 0xf6db7ffc => 17
	i32 4151237749, ; 265: System.Core => 0xf76edc75 => 51
	i32 4182413190, ; 266: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 94
	i32 4213026141, ; 267: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 52
	i32 4258913604, ; 268: Microsoft.AspNetCore.Mvc.DataAnnotations => 0xfdd9dd44 => 26
	i32 4260525087, ; 269: System.Buffers => 0xfdf2741f => 50
	i32 4267317823, ; 270: SeenIT.Android => 0xfe5a1a3f => 0
	i32 4292120959 ; 271: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 94
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [272 x i32] [
	i32 35, i32 92, i32 121, i32 48, i32 116, i32 36, i32 106, i32 134, ; 0..7
	i32 106, i32 131, i32 73, i32 30, i32 107, i32 71, i32 87, i32 129, ; 8..15
	i32 76, i32 91, i32 85, i32 14, i32 63, i32 55, i32 26, i32 89, ; 16..23
	i32 27, i32 29, i32 54, i32 75, i32 115, i32 5, i32 84, i32 47, ; 24..31
	i32 53, i32 85, i32 96, i32 19, i32 44, i32 123, i32 4, i32 3, ; 32..39
	i32 127, i32 80, i32 59, i32 112, i32 68, i32 62, i32 17, i32 126, ; 40..47
	i32 43, i32 125, i32 103, i32 0, i32 121, i32 48, i32 89, i32 12, ; 48..55
	i32 5, i32 4, i32 105, i32 33, i32 67, i32 118, i32 36, i32 93, ; 56..63
	i32 53, i32 31, i32 38, i32 14, i32 37, i32 110, i32 100, i32 68, ; 64..71
	i32 45, i32 19, i32 111, i32 29, i32 82, i32 8, i32 7, i32 130, ; 72..79
	i32 105, i32 97, i32 77, i32 57, i32 3, i32 119, i32 126, i32 66, ; 80..87
	i32 44, i32 9, i32 81, i32 11, i32 95, i32 114, i32 79, i32 10, ; 88..95
	i32 58, i32 108, i32 120, i32 76, i32 6, i32 49, i32 72, i32 107, ; 96..103
	i32 51, i32 84, i32 95, i32 120, i32 101, i32 23, i32 41, i32 115, ; 104..111
	i32 119, i32 69, i32 31, i32 98, i32 20, i32 50, i32 93, i32 90, ; 112..119
	i32 20, i32 58, i32 56, i32 86, i32 117, i32 43, i32 25, i32 41, ; 120..127
	i32 35, i32 10, i32 42, i32 110, i32 21, i32 96, i32 98, i32 88, ; 128..135
	i32 32, i32 104, i32 24, i32 64, i32 24, i32 133, i32 102, i32 132, ; 136..143
	i32 15, i32 75, i32 1, i32 13, i32 2, i32 124, i32 92, i32 16, ; 144..151
	i32 59, i32 111, i32 37, i32 28, i32 18, i32 79, i32 83, i32 91, ; 152..159
	i32 22, i32 7, i32 108, i32 63, i32 16, i32 66, i32 116, i32 113, ; 160..167
	i32 77, i32 61, i32 23, i32 113, i32 109, i32 6, i32 128, i32 47, ; 168..175
	i32 114, i32 56, i32 65, i32 18, i32 82, i32 21, i32 87, i32 15, ; 176..183
	i32 22, i32 12, i32 99, i32 11, i32 28, i32 60, i32 25, i32 122, ; 184..191
	i32 81, i32 27, i32 135, i32 72, i32 60, i32 70, i32 131, i32 30, ; 192..199
	i32 80, i32 122, i32 69, i32 100, i32 86, i32 78, i32 13, i32 104, ; 200..207
	i32 57, i32 130, i32 34, i32 61, i32 1, i32 83, i32 46, i32 123, ; 208..215
	i32 74, i32 70, i32 62, i32 49, i32 117, i32 128, i32 39, i32 8, ; 216..223
	i32 102, i32 133, i32 103, i32 118, i32 65, i32 9, i32 90, i32 132, ; 224..231
	i32 32, i32 46, i32 129, i32 71, i32 74, i32 125, i32 64, i32 99, ; 232..239
	i32 52, i32 88, i32 42, i32 39, i32 73, i32 97, i32 55, i32 33, ; 240..247
	i32 134, i32 109, i32 78, i32 40, i32 127, i32 112, i32 101, i32 124, ; 248..255
	i32 40, i32 67, i32 54, i32 45, i32 38, i32 135, i32 34, i32 2, ; 256..263
	i32 17, i32 51, i32 94, i32 52, i32 26, i32 50, i32 0, i32 94 ; 272..271
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
