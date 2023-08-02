# Underlay Passthrough MRTK3 for the Quest2/Pro

## Description

Here I will explain how to get the underlay passthrough working for the quests on the MRTK3 systems.
This can be really useful for cross platform development for the Hololens 2 and other Quest devices.

![text](https://github.com/DazzTDuck/Quest_Passthrough_MRTK3/blob/main/ReadmeGifs(ignore)/example1.gif)

* This project uses Unity version: 2022.2.3f1

## IMPORTANT NOTE

* If you build the project, **MAKE SURE** you have set the Android plugin provider to **OpenXR**, otherwise you don't have hand tracking.

* With underlay, objects are fully opaque, so you cannot see the passthrough behind objects. So if you want to be able to always see the passthrough or have the same feel as a Hololens, set the passthrough layer on overlay and set the opacity to 0.2-0.3.

![text](https://i.ibb.co/7RFMf1F/Screenshot-8.png)

## Getting Started

* You can copy the demo project from this repository to use as a base or you can create your own project.
* With your own project you need to install MRTK3 and the Oculus Intergration package into it.

### How to setup the passthrough

1. **Drag the MRTK XR Rig into your scene**

 ![text](https://i.ibb.co/yyGmR9g/Screenshot-1.png)
 
2. **Open the rig and click on the Main Camera object**

 !![text](https://i.ibb.co/qyZHNXc/Screenshot-2.png)
 
3. **Turn off HDR on the camera, and then you can close the rig**

 ![text](https://i.ibb.co/cD7HjJ8/Screenshot-3.png)

4. **Create and empty object and call it "Passthrough", on this object add the "OVR Manager" and "OVR Passthrough Layer" compontents**

 ![text](https://i.ibb.co/jGVw0Lj/Screenshot-4.png)

5. **In the OVR Manager, set Hand tracking support to 'Controller and hands' and set the frequency to 'MAX'.**
6. **Then set the Passthrough support to 'Supported' and make sure 'Enable Passthrough' is checked.**

 ![text](https://i.ibb.co/V3D6Qk2/Screenshot-9.png)

7. **Open the OVR Passthrough Layer and set the Placement to Underlay**

 ![text](https://i.ibb.co/hHv6W0c/Screenshot-6.png)

8. **And to make sure the passthrough works you need to add the 'Enable Unpremultiplied Alpha' component to the object**

 ![text](https://i.ibb.co/XZJQ9vH/Screenshot-7.png)
 
 > If you want to know what the script does, you can open it and it explains why the script is important
 
 ### Last thing to keep in mind!
 
 > When you want to test something in play mode inside the editor, you need to change this setting EVERYTIME you open the project, else the editor will crash.
 
  ![text](https://i.ibb.co/Vpc17bf/Image1-Settings.png)
  
 > Go to your project settings, and under XR Plug-in Management open the OpenXR tab. You should see the option "Play Mode OpenXR Runtime"
 
  ![text](https://i.ibb.co/mc4XvsC/Image2-Settings.png)
  
 >  Make sure to change this to "Windows Mixed Reality", this will fix the crash problem. 

### And now if you build the application on android you should have proper passthrough!

- Last thing you need to do if you want to use the application for a Hololens, the object needs to be disabled if running on a Hololens otherwise it will crash. 
- Simply use a script that uses 'Preceding Conditional Compilation' to disable the object when running on 'UNITY_WSA' (this is the platform the Hololens runs on) and then it will get disabled on the Hololens and you can use all the features as normal! I have a script that handles this in the repository so you could use that.
- You can find the script in the Assets folder, the script is called "DisableForHololens".

## Authors

Yerio Janssen  
* [LinkedIn](https://www.linkedin.com/in/yerio-janssen-a20980239/)

## Acknowledgments

I got the idea to figure this out from "Joost van Schaik"
* [LinkedIn Joost](https://www.linkedin.com/in/joostvanschaik/)
* [Joost's Blog on overlay passthrough](https://localjoost.github.io/Passthrough-transparency-with-MRTK2-and-3-on-Quest-2Pro/)
