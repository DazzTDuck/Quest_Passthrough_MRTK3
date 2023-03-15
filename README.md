# Underlay Passthrough MRTK3 for the Quest2/Pro

## Description

Here I will explain how to get the underlay passthrough working for the quests on the MRTK3 systems.
This can be really useful for cross platform development for the Hololens 2 and other Quest devices.

* This project uses Unity version: 2022.2.3f1

## IMPORTANT NOTE

With underlay, you cannot see through objects so that means behind a object you cannot see the real world.
So if you want to always see the real world, set the passthrough layer on overlay and set the opacity to 0.2-0.3.

## Getting Started

* You can copy the demo project from this repository to use as a base or you can create your own project.
* With your own project you need to install MRTK3 and the Oculus Intergration package into it.

### How to setup the passthrough

1. **Drag the MRTK XR Rig into your scene**

 ![text](https://i.ibb.co/yyGmR9g/Screenshot-1.png)
 
 1. **Open the rig and click on the Main Camera object**

 ![text](https://i.ibb.co/yyGmR9g/Screenshot-2.png)

## Authors

Yerio Janssen  
* [LinkedIn](https://www.linkedin.com/in/yerio-janssen-a20980239/)

## Acknowledgments

I got the idea to figure this out from "Joost van Schaik"
* [LinkedIn Joost](https://www.linkedin.com/in/joostvanschaik/)
* [Joost's Blog on overlay passthrough](https://localjoost.github.io/Passthrough-transparency-with-MRTK2-and-3-on-Quest-2Pro/)
