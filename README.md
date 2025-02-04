# Azure-PixelStreamingCopilot-Sample

## Important Update

Per [Pixel Streaming in Azure](https://github.com/Azure/Unreal-Pixel-Streaming), Azure Marketplace deployment item for Azure Unreal Pixel Streaming has been deprecated in June 2024, and Epic Games has open sourced the solution [here](https://github.com/ue4plugins/UnrealPixelStreamingOnAzure).

## Welcome

Welcome to the Azure Pixel Streaming Copilot Sample repository on GitHub. This code base written with the help of [ChatGPT](https://chat.openai.com/) and [GitHub Copilot](https://github.com/features/copilot) serves as a reference implementation of an Unreal 4.x/5.x Pixel Streaming Copilot Immersive Experience App in Microsoft Azure Cloud based on Epic Games' Unreal Pixel Streaming Technology. To gracefully and intuitively bring in Copilot capabilities it integrates with Azure Speech SDK, Azure OpenAI Generative AI models and OpenAI Generative AI models, including multi-modal GPT-4V (GPT-4 with Vision) model. It's a great example of modern innovation leveraging robust Microsoft Azure Cloud capabilities for Cloud-based GPU Compute, best practices for building full-stack Azure Cloud solution architectures for modern web applications, and streaming high definition and high quality interactive 3D content via Epic Games' Unreal Pixel Streaming Technology at real-time on-demand in the web browser of your choice (Microsoft Edge, Google Chrome, Apple Safari, etc.) on the device of your choice (PC/Mac, tablet/iPad, phone/iPhone, etc.) securely over Internet.

## Motivation

Make everything as simple as possible, but not simpler.

## Getting Started

This Unreal Engine sample is intended for Unreal Engine apps packaged for Windows platform. Once packaged Unreal Engine app zip archive gets placed in Azure Blob Storage container, from which it is referenced during Azure Unreal Pixel Streaming Marketplace item deployment. This deployment results in creation of the necessary IaaS Azure Cloud infrastructure and PaaS Azure Cloud Services which consist of Azure Traffic Manager, Matchmaking Server(s) VMs, Signalling Server(s) VM Scale sets, Azure Blob Storage, Azure Key Vault, etc. to support a desired number of streams in a multi-region deployment. Generative AI capabilities of Azure Open AI and optionally OpenAI are used along with Azure Speech SDK for implementing a Copilot which can hear, speak, see and interact with You in a meaningful way.

This sample is built based on the following foundational GitHub templates and software packages:

* [Azure Speech SDK for JavaScript (Browser) Bundle](https://cdn.jsdelivr.net/npm/microsoft-cognitiveservices-speech-sdk/distrib/browser/)
* [Synthesize speech using Azure Speech SDK for JavaScript](https://github.com/Azure-Samples/cognitive-services-speech-sdk/blob/master/samples/js/node/synthesis.js)
* [Recognize speech using Azure Speech SDK for JavaScript](https://github.com/Azure-Samples/cognitive-services-speech-sdk/blob/master/samples/js/node/speech.js)
* [Get speech token using Azure Speech SDK for JavaScript  (Token Exchange Process)](https://github.com/Azure-Samples/cognitive-services-speech-sdk/blob/master/samples/js/browser/server/index.js)
* [Azure Speech React Sample (Token Exchange Process)](https://github.com/Azure-Samples/AzureSpeechReactSample?tab=readme-ov-file#token-exchange-process)
* [Azure Pixel Streaming for Unreal Engine (Customization Package)](https://uepixelbackend.blob.core.windows.net/publicblobs/WebServers_Marketplace_4.27.3.zip)

Solution architecture of this template is described in detail in the following Medium articles:

* [TBD](https://alexanikiev.medium.com/) (Medium article on "Building Modern Immersive Experiences for Industrial Metaverse using Microsoft Azure Cloud" will be published soon) 

Solution demo videos and technical walkthroughs are available on YouTube:

* [Azure Unreal Pixel Streaming for UE5.2 or UE5.3 on NC or NV-Families GPU Compute in Microsoft Azure](https://www.youtube.com/watch?v=Dd2ziUFdVq4)
* [Scaling & Multi-streaming with Azure Unreal Pixel Streaming for UE on GPU Compute in Microsoft Azure](https://www.youtube.com/watch?v=NuUfVDxJ1UI)
* [Scaling & Multi-streaming with Azure Unreal Pixel Streaming for UE in Microsoft Azure Cont'ed](https://www.youtube.com/watch?v=XmmCH47FCpc)
* [Azure Unreal Pixel Streaming Copilot Demo powered by Azure OpenAI GPT-4 & OpenAI GPT-4V with Vision](https://www.youtube.com/watch?v=gI8ws0zWJxM)
* [Azure Unreal Pixel Streaming Secure Deployment of Azure Marketplace Item](https://www.youtube.com/watch?v=hSXa7bdZ4t4)

## Prerequisites

Please see the list below with compatibility guidance for the versions of software the sample was developed and tested on.

| Prerequisite                              | Download Link                                                                                  | Version      |
|-------------------------------------------|------------------------------------------------------------------------------------------------|--------------|
| Unreal Engine                             | https://www.unrealengine.com/en-US/download                                                    | 5.3          |
| Azure Speech SDK for JavaScript (Browser) | https://www.npmjs.com/package/microsoft-cognitiveservices-speech-sdk                           | 1.34.0       |
| Azure OpenAI Studio                       | https://oai.azure.com/                                                                         | GPT-4/GPT-4V |
| OpenAI Plus                               | https://platform.openai.com/                                                                   | GPT-4/GPT4-V |
| Azure Unreal Pixel Streaming              | https://azuremarketplace.microsoft.com/en-us/marketplace/apps/epicgames.unreal-pixel-streaming | 4.27.3       |

Please note that you will only need to install Unreal Engine 5.3 or later if you plan to create your own customizations to Unreal Engine package using Unreal Engine Blueprints, otherwise you are welcome to use already pre-packaged customized Unreal Engine ThirdPerson Template Project [here](https://github.com/alexanikiev/Azure-PixelStreamingCopilot-Sample/blob/main/uepixelfrontend/packages/ThirdPersonCustom.zip). This sample takes advantage of Azure Marketplace Unreal Pixel Streaming item [here](https://portal.azure.com/#create/epicgames.unreal-pixel-streamingunreal-pixel-streaming) for deploying multi-region deployment of Azure Unreal Pixel Streaming. Please see Solution Architecture diagram below for more details.

## Solution Architecture

![Solution Architecture](/docs/images/uepixelbackend-copilot-dark.png)

Please find more information about multi-region Azure Unreal Pixel Streaming deployment architecture [here](https://learn.microsoft.com/en-us/gaming/azure/reference-architectures/unreal-pixel-streaming-in-azure) and [here](https://docs.unrealengine.com/5.3/en-US/deploying-unreal-engine-pixel-streaming-on-azure/).

## Installing

After you've cloned or downloaded the repository, please review Copilot related customizations done on top of [this](https://uepixelbackend.blob.core.windows.net/publicblobs/WebServers_Marketplace_4.27.3.zip) default Azure Unreal Pixel Streaming Customization Package [here](https://github.com/alexanikiev/Azure-PixelStreamingCopilot-Sample/tree/main/uepixelbackend/SignallingWebServer) marked with `Customization` keyword in the code. Please note that the pre-packaged customized Unreal Engine ThirdPerson Template Project file is stored with Git LFS and can be downloaded from [here](https://github.com/alexanikiev/Azure-PixelStreamingCopilot-Sample/blob/main/uepixelfrontend/packages/ThirdPersonCustom.zip).

Then according to the customization instructions [here](https://github.com/alexanikiev/Azure-PixelStreamingCopilot-Sample/blob/main/uepixelbackend/README.txt), please optionally re-package app zip archive to accomodate for more customizations of your choice and upload the resulting zip archive into Azure Blob Storage container. In essence, customizations to Azure Unreal Pixel Streaming can be done in Unreal Engine app itself using Blueprints, web browser User Interface written using JavaScript & HTML and/or web servers (MatchMaking Server and Signalling WebRTC Server (Cirrus)) written in NodeJS. All these customizations are packages into Unreal Engine app package for convenience. Please note that if you made customizations to the web browser User Interface or NodeJS web servers, it is important to check `I have made custom modifications to the Matchmaker and Signalling web servers` checkbox when deploying Azure Unreal Pixel Streaming Marketplace item and supply your customizations in the `Source` folder in the respective package zip archive.

Please learn more about Unreal Engine Pixel Streaming in general [here](https://docs.unrealengine.com/5.3/en-US/pixel-streaming-in-unreal-engine/). When it comes to customizing Unreal Pixel Streaming User Interface, [this](https://docs.unrealengine.com/5.3/en-US/customizing-the-player-web-page-in-unreal-engine/) article lays an important foundation for understanding how to do it. Please note that Azure Unreal Pixel Streaming Marketplace item is compatible with Unreal Engine 4.x/5.x apps and leverages monolitic JavaScript files approach as described in `Changes from Previous Versions` section. Namely, we mean `app.js` and `webrtcplayer.js` files. Please do not confuse it with the new way of customizing User Interface using Frontend project available on GitHub [here](https://github.com/EpicGames/PixelStreamingInfrastructure/tree/master/Frontend). 

We can set up bi-directional communication between Unreal Engine app running in Azure Cloud and web browser with the help of Unreal Engine Blueprints as described [here](https://docs.unrealengine.com/5.3/en-US/interacting-with-the-pixel-streaming-system-in-unreal-engine/). Specifically, `Communicating from UE5 to the Player Page` section details how to send events from Unreal Engine app to the web browser (including complex data in form of a JSON), and `Responding to Pixel Streaming Events` section talks about sending events from the web browser to Unreal Engine app.

To make appropriate Unreal Engine Blueprint customizations in our ThirdPerson app template we can follow [this](https://github.com/EpicGames/PixelStreamingInfrastructure/blob/master/Frontend/Docs/Communicating%20from%20the%20Player%20Page%20to%20UE5.md) guidance for the web browser to Unreal app communication, and [this](https://github.com/EpicGames/PixelStreamingInfrastructure/blob/master/Frontend/Docs/Communicating%20from%20UE5%20to%20the%20Player%20Page.md) guidance for Unreal app to the web browser communication. Please also note that it is important to enable `AllowPixelStreamingCommands` flag while deploying Azure Unreal Pixel Streaming Marketplace item to enable such communication in general.

This is how customized ThirdPerson Character Blueprint looks like in Unreal Engine with all the necessary plumbing for Azure Unreal Pixel Streaming bi-directional communication:

![ThirdPerson Character Blueprint](/docs/images/uepixelstreaming-thirdpersoncharacter-blueprint.png)

To enable Copilot functionality leveraging Generative AI in Azure Unreal Pixel Streaming deployment we introduced an additional serverless backend in the Cloud with the help of Azure Function Host. There're dedicated functions for Web API-based integration with Azure OpenAI multi-modal models as well as a function to generate Azure Speech SDK perishable token. Azure Speech SDK is integrated directly via JavaScript CDN minified distribution bundle in the web browser and takes advantage of your device's microphone and speaker capabilities. 

For developing Azure Function Host Web APIs we used a standard C#.NET MVC template which we modified to formally introduce a simple services layer. Please find more information about creating Azure Functions using C# [here](https://learn.microsoft.com/en-us/azure/azure-functions/functions-create-your-first-function-visual-studio). You can also learn more about architecting and developing Modern Web Applications with ASP.NET and Azure [here](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures), specifically check out the concepts of Clean Architecture [here](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#clean-architecture) and in [this](https://github.com/alexanikiev/Azure-CleanArchitectureServerless-Sample) GitHub repository. 

In order to configure Azure Function Host App Settings with secrets needed to connect to Azure OpenAI Web APIs it is our preference to use Azure Key Vault References per guidance [here](https://learn.microsoft.com/en-us/azure/app-service/app-service-key-vault-references?tabs=azure-cli#source-app-settings-from-key-vault), and set up service to service trust between Azure Function Host and Azure Key Vault based on Azure Managed Identities.

In case you need to modify the logic for MatchMaker Server and Signalling Server (Cirrus) web servers as a part of your Azure Unreal Pixel Streaming solution, you can always do so by customizing NodeJS code for the respective component and include these customizations in the `Source` folder in your packaged customized Unreal app (zip archive). 

Finally, please review Unreal Pixel Streaming documentation [here](https://docs.unrealengine.com/5.3/en-US/getting-started-with-pixel-streaming-in-unreal-engine/) to make sure you prepare your Unreal project for packaging and deployment to Azure Cloud and the core pre-requisites (such as Pixel Streaming Add-in enabled, touch controls enabled, default level set, etc.) are met for your success.

## Cloud Deployment

This sample *will* feature One-Click Deployment for the necessary Azure Backend services. If you need to sign up for Azure Subscription please follow [this](https://azure.microsoft.com/en-us/free/) link.

Attention: This section is still under construction, please check back later. At this point you may utilize One-Click deployment for Azure Unreal Pixel Streaming Marketplace item [here](https://portal.azure.com/#create/epicgames.unreal-pixel-streamingunreal-pixel-streaming) in Azure Portal and Visual Studio or Visual Studio Code for easy Azure Function Host deployment.

[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Falexanikiev%2FAzure-PixelStreamingCopilot-Sample%2Fmain%2Fcloud%2Finfra%2Ftemplate.json)

## AIC (or CIA) Framework: Availability, Integrity, Confidentiality 

1. Availability: Availability ensures that the gaming platform and its services are available to users whenever needed. High availability is critical for online gaming platforms, as downtime can lead to a poor user experience, frustration among players, and financial loss. To support availability, systems must be designed to handle high volumes of traffic, resist and recover from DDoS (Distributed Denial of Service) attacks, and employ redundant infrastructure to minimize downtime.  
2. Integrity: Integrity involves maintaining the accuracy and reliability of data and ensuring that it is not tampered with. In online gaming, integrity ensures that game data, user progress, in-game assets, and financial transactions are protected from unauthorized alterations. Mechanisms like cryptographic hashes, digital signatures, and secure and resilient databases are employed to safeguard data integrity. Ensuring integrity also involves protecting the game's logic from manipulation, cheating, and exploits that could undermine the fairness and competitive balance of the game.  
3. Confidentiality: Confidentiality focuses on ensuring that sensitive information is accessible only to authorized individuals. In the context of online gaming, confidentiality means protecting user data, such as personal information, payment details, chat logs, and gaming habits, from unauthorized access and disclosure. Techniques such as encryption (both at rest and in transit), strong authentication methods, and access control mechanisms are essential for maintaining confidentiality. 

## Security Checklist
1. Infrastructure Security:  
- Secure the underlying Azure Cloud infrastructure.  
- Implement strict access controls and network segmentation.  
- Harden operating systems and services against vulnerabilities.  
2. Application Security:  
- Conduct thorough security assessments, including penetration testing and vulnerability scanning, on the Unreal Pixel Streaming application.  
- Implement secure coding practices and conduct code reviews focused on security.  
- Use Web Application Firewalls (WAF) to protect against common web vulnerabilities.  
- Ensure secure implementation of WebRTC to prevent eavesdropping and data tampering. 
3. Network Security:  
- Encrypt all data in transit using strong encryption protocols (e.g., TLS for web traffic).  
- Deploy DDoS protection mechanisms to mitigate the risk of denial-of-service attacks.  
- Implement network monitoring to detect and respond to suspicious activities. 
- Implement least privilege controls to limit available ports and protocols to only those necessary to run Pixel streaming. Between external environments and between internal subnets. 
4. Data Security:  
- Encrypt sensitive data at rest, including player information and payment details.  
- Implement robust data backup and recovery procedures.  
- Ensure proper data retention policies are in place and followed. 
5. Identity and Access Management:  
- Implement strong authentication mechanisms, including multi-factor authentication for users and administrators.  
- Enforce least privilege access to minimize exposure of sensitive systems and data.  
- Manage user sessions securely, with timeouts and re-authentication where necessary.  
6. Monitoring and Incident Response:  
- Deploy a comprehensive monitoring solution to log and analyze events across the platform.  
- Establish a 24/7 incident response team capable of responding to security incidents swiftly.  
- Test incident response plans to ensure effectiveness. 
7. Compliance and Regulatory:  
- Adhere to relevant international and local regulations, such as GDPR for data protection in Europe.  
- Ensure compliance with industry standards, such as ISO/IEC 27001 for information security management if necessary.  
- Undergo third-party security assessments and audits if necessary.  
8. User Education and Awareness:  
- Educate users on secure practices.  
- Provide clear guidelines and support for reporting suspicious activities or security concerns.

## Next Steps

This minimalistic template may be a great jump start for your own Azure Unreal Pixel Streaming project and the possibilities from now on are truly endless.

Please consider these critical Security Hardening measures to take this minimalistic template forward:
1. Implement Application Gateway / WAF (Web Application Firewall) which includes protection from DDOS for Matchmaking Servers and Signaling Servers (Cirrus) 
2. Limit TCP communication from Signaling Servers (Cirrus) from only Matchmaking Servers by configuring up NSG (Network Security Groups) rules. _Note: Cannot be implemented at the UDP layer._ 
3. Implement more robust Authentication mechanism. _Note: The current authentication using hashed passwords stored in Azure Blob Storage is too basic for Production, Security and Scale._  

## Future Updates

* Finalize infrastructure ARN template for combined Azure Unreal Pixel Streaming Marketplace item deployment and Azure Function Host Web APIs deployments
* Publish "Building Modern Immersive Experiences for Industrial Metaverse using Microsoft Azure Cloud" Medium article [here](https://alexanikiev.medium.com/)

## Azure OpenAI

For Copilot functionality we leveraged Azure OpenAI Generative AI models, namely GPT-4 and GPT-4V (Vision). GPT-4 text-only model's Chat (or Completions) endpoint was used to set up an intelligent assistant for conversations.

While using GPT-4 model(s) quickly became ubiquotous amongst developers, we will just briefly touch upon technical aspects while using multi-modal [GPT-4V (Vision)](https://openai.com/research/gpt-4v-system-card) model. 

A novel way to leverage multi-modality (text and image(s)) is to use GPT-4V (Vision) based on "screenshots" of the screen taken from a live Unreal stream and sent to Generative AI to help interpret "what Am I looking at?" in a specific context. For that we automated the process of "taking a screenshot" on the screen using JavaScript so we can send it to GPT-4V (Vision) model in its base64 representation, the results received are spoken out load using Azure Speech SDK. Please find guidance [here](https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/gpt-with-vision) on how to use GPT-4V (Vision) multi-modal model in Azure OpenAI via Web API. Alternatively (if needed) you may leverage OpenAI GPT-4V (Vision) multi-modal model via Web API as described [here](https://platform.openai.com/docs/guides/vision).

Example GPT-4V (Vision) Web API request may look like the following:

```curl
curl --location 'https://abc.openai.azure.com/openai/deployments/gpt-4v/chat/completions?api-version=2023-12-01-preview' \
--header 'Content-Type: application/json' \
--header 'api-key: xyz' \
--data '{
    "messages": [ 
        {
            "role": "system", 
            "content": "Your Copilot configuration" 
        },
        {
            "role": "user", 
            "content": [
                {
                    "type": "text",
                    "text": "Describe this picture:"
                },
                {
                    "type": "image_url",
                    "image_url": {
                        "url": "data:image/png;base64,123"
                    }
                } 
           ] 
        }
    ],
    "max_tokens": 100, 
    "stream": false 
} '
```

## Important Considerations

Following are important considerations on how to prepare your Azure Subscription for deploying this sample:

* For leveraging Azure Cloud GPU Compute VMs your Azure Subscription will likely need to be enabled for deploying selected GPU-enabled SKUs of VMs (for example, NC or NV series) which may involve Azure Policies
* For successfull deployment of GPU-enabled VMs as a part of Azure Unreal Pixel Streaming Marketplace item you will likely need to request a quota increase for selected SKUs in [regions]() of your choice via Azure Support
* Please consider using [NVadsA10 v5-series](https://learn.microsoft.com/en-us/azure/virtual-machines/nva10v5-series) (Standard_NV18ads_A10_v5, Standard_NV36ads_A10_v5, etc.) VM SKUs for your Axure Unreal Pixel Streaming deployment(s)
* Please be cognizant of the fact that even after you have successfully deployed Azure Unreal Pixel Streaming Marketplace item in your Azure Subscription there still may be some subscription level policies that kick off afterwards and change initial configuration (for example, networking setup per corporate security), thus you may need to re-adjust some configurations later
* Please know that Azure VMs deployed by Azure Unreal Pixel Streaming Marketplace item inherit VM Extension(s) which may define behaviors like auto shut-down, etc. which you may want to adjust after initial deployment
* Please note that if connected to corporate network(s) your corporate networking configuration may block WebRTC traffic and be unable to do NAT (Network Address Translation), thus you may need to use VPN(s) as a workaround
* Please make sure to deploy Azure Unreal Pixel Streaming Marketplace item securely using HTTPS because Azure Speech SDK for JavaScript in the browser won't work over unsecure HTTP
* For issuing wildcard SSL certificate(s) for your secure deployment of Azure Unreal Pixel Streaming Marketplace item you may consider using Let's Encrypt [CertBot](https://certbot.eff.org/)
* For using Azure OpenAI Generative AI multi-modal models you may need to request access for your Azure Subscription [here](https://aka.ms/oai/access)
* For using OpenAI Generative AI multi-modal models via Web APIs you may need to upgrade to OpenAI Plus account with some funds available there

## Disclaimer

This code is provided "as is" without warranties to be used at your own risk. Parts of the code openly available on Internet are subject for copyright by Microsoft and Epic Games and marked as such inline.
