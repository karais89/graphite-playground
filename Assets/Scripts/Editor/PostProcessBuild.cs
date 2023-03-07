public class PostProcessBuild
{
    // [PostProcessBuild(100)]
    // public static void OnPostProcessBuild1(BuildTarget buildTarget, string path)
    // {
    //     Debug.Log("======== 1111111111111111 OnPostProcessBuild");

    //     if (buildTarget != BuildTarget.iOS)
    //     {
    //         return;
    //     }
        
    //     // //Xcode 프로젝트의 경로를 얻어오기
    //     // var xcodeprojPath = Path.Combine(path, "Unity-iPhone.xcodeproj");
    //     // var pbxprojPath = Path.Combine(xcodeprojPath, "project.pbxproj");

    //     // //Xcode 프로젝트 로드
    //     // PBXProject proj = new PBXProject();
    //     // proj.ReadFromFile(pbxprojPath);

    //     // var target = proj.TargetGuidByName("Unity-iPhone");

    //     // proj.AddFrameworkToProject(target, "Social.framework", false);
    //     // proj.WriteToFile(pbxprojPath);
    // }


    // [PostProcessBuild(200)]
    // public static void OnPostProcessBuild2(BuildTarget buildTarget, string path)
    // {
    //     Debug.Log("======== 2222222222222222 OnPostProcessBuild");

    //     // {
    //     //     string projPath = path + "/Unity-iPhone.xcodeproj/project.pbxproj";
            
    //     //     PBXProject proj = new PBXProject();
    //     //     proj.ReadFromString(File.ReadAllText(projPath));
            
    //     //     string target = proj.GetUnityMainTargetGuid();
    //     //     proj.RemoveFrameworkFromProject(target, "StoreKit.framework");

    //     //     string[] linkerFlagsToAdd = { "-framework StoreKit" };
    //     //     proj.UpdateBuildProperty(target, "OTHER_LDFLAGS", linkerFlagsToAdd, null);
            
    //     //     File.WriteAllText(projPath, proj.WriteToString());
    //     // }
    // }

    // [PostProcessBuild(300)]
    // public static void OnPostProcessBuild3(BuildTarget buildTarget, string path)
    // {
    //     Debug.Log("======== 33333333333333333 OnPostProcessBuild");
    // }
}
