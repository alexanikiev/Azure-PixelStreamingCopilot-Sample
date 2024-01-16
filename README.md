# Azure-PixelStreamingCopilot-Sample

Welcome to the Azure Pixel Streaming Copilot Sample repository on GitHub. This code base written with the help of [ChatGPT](https://chat.openai.com/) and [GitHub Copilot](https://github.com/github/copilot) serves as a reference implementation of an Unreal 4.x/5.x Pixel Streaming Copilot Immersive Experience App in Microsoft Azure Cloud based on Epic Games' Unreal Pixel Streaming Technology. To gracefully and intuitively bring in Copilot capabilities it integrates with Azure Speech SDK, Azure OpenAI Generative AI models and OpenAI Generative AI models, including multi-modal GPT-4V (GPT-4 with Vision) model. It's a great example of modern innovation leveraging robust Microsoft Azure Cloud capabilities for Cloud-based GPU Compute, best practices for building full-stack Azure Cloud solution architectures for modern web applications, and streaming high definition and high quality interactive 3D content via Epic Games' Unreal Pixel Streaming Technology at real-time on-demand in the web browser of your choice (Microsoft Edge, Google Chrome, Apple Safari, etc.) on the device of your choice (PC/Mac, tablet/iPad, phone/iPhone, etc.) securely over Internet.

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

Please note that you will only need to install Unreal Engine 5.3 or later if you plan to create your own customizations to Unreal Engine package using Unreal Engine Blueprints, otherwise you are welcome to use already pre-packaged customized Unreal Engine ThirdPerson Template Project [here](). This sample takes advantage of Azure Marketplace Unreal Pixel Streaming item [here](https://portal.azure.com/#create/epicgames.unreal-pixel-streamingunreal-pixel-streaming) for deploying multi-region deployment of Azure Unreal Pixel Streaming. Please see Solution Architecture diagram below for more details.

## Solution Architecture

![Solution Architecture](/docs/images/uepixelbackend-copilot-dark.png)

## Installing

After you've cloned or downloaded the repository, please review Copilot related customizations done on top of [this](https://uepixelbackend.blob.core.windows.net/publicblobs/WebServers_Marketplace_4.27.3.zip) default Azure Unreal Pixel Streaming Customization Package [here]() marked with `Customization` keyword in the code. Please note that the pre-packaged customized Unreal Engine ThirdPerson Template Project file is stored with Git LFS and can be downloaded from [here]().

Then according to customization instructions [here](https://github.com/alexanikiev/Azure-PixelStreamingCopilot-Sample/blob/main/uepixelbackend/README.txt), please optionally re-package app zip archive to accomodate for more customizations of your choice and upload the resulting zip archive into Azure Blob Storage container. In essence, customizations to Azure Unreal Pixel Streaming can be done in Unreal Engine app itself using Blueprints, web browser User Interface written using JavaScript & HTML and/or web servers (MatchMaking Server and Signalling WebRTC Server (Cirrus)) written in NodeJS. All these customizations are packages into Unreal Engine app package for convenience. Please note that if you made customizations to the web browser User Interface or NodeJS web servers, it is important to check `I have made custom modifications to the Matchmaker and Signalling web servers` checkbox when deploying Azure Unreal Pixel Streaming Marketplace item and supply your customizations in the `Source` folder in the respective package zip archive.

Please learn more about Unreal Engine Pixel Streaming in general [here](https://docs.unrealengine.com/5.3/en-US/pixel-streaming-in-unreal-engine/). When it comes to customizing Unreal Pixel Streaming User Interface, [this](https://docs.unrealengine.com/5.3/en-US/customizing-the-player-web-page-in-unreal-engine/) article lays an important foundation for understanding how to do it. Please note that Azure Unreal Pixel Streaming Marketplace item is compatible with Unreal Engine 4.x/5.x apps and leverages monolitic JavaScript files approach as described in `Changes from Previous Versions` section. Namely, we mean `app.js` and `webrtcplayer.js` files. Please do not confuse it with the new way of customizing User Interface using Frontend project available on GitHub [here](https://github.com/EpicGames/PixelStreamingInfrastructure/tree/master/Frontend). 

We can set up bi-directional communication between Unreal Engine app running in Azure Cloud and web browser with the help of Unreal Engine Blueprints as described [here](https://docs.unrealengine.com/5.3/en-US/interacting-with-the-pixel-streaming-system-in-unreal-engine/). Specifically, `Communicating from UE5 to the Player Page` section details how to send events from Unreal Engine app to the web browser (including complex data in form of a JSON), and `Responding to Pixel Streaming Events` section talks about sending events from the web browser to Unreal Engine app.

To make appropriate Unreal Engine Blueprint customizations in our ThirdPerson app template we can follow [this](https://github.com/EpicGames/PixelStreamingInfrastructure/blob/master/Frontend/Docs/Communicating%20from%20the%20Player%20Page%20to%20UE5.md) guidance for the web browser to Unreal app communication, and [this](https://github.com/EpicGames/PixelStreamingInfrastructure/blob/master/Frontend/Docs/Communicating%20from%20UE5%20to%20the%20Player%20Page.md) guidance for Unreal app to the web browser communication. Please also note that it is important to enable `AllowPixelStreamingCommands` flag while deploying Azure Unreal Pixel Streaming Marketplace item to enable such communication in general.

To enable Copilot functionality leveraging Generative AI in Azure Unreal Pixel Streaming deployment we introduced an additional serverless backend in the Cloud with the help of Azure Function Host. There're dedicated functions for Web API-based integration with Azure OpenAI multi-modal models as well as a function to generate Azure Speech SDK perishable token. Azure Speech SDK is integrated directly via JavaScript CDN minified distribution bundle in the web browser and takes advantage of your device's microphone and speaker capabilities. 

In order to configure Azure Function Host App Settings with secrets needed to connect to Azure OpenAI Web APIs it is our preference to use Azure Key Vault References per guidance [here](https://learn.microsoft.com/en-us/azure/app-service/app-service-key-vault-references?tabs=azure-cli#source-app-settings-from-key-vault), and set up service to service trust between Azure Function Host and Azure Key Vault based on Azure Managed Identities.

## Cloud Deployment

This sample features One-Click Deployment for the necessary Azure Backend services. If you need to sign up for Azure Subscription please follow [this](https://azure.microsoft.com/en-us/free/) link.

[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Falexanikiev%2FAzure-PixelStreamingCopilot-Sample%2Fmain%2Fcloud%2Finfra%2Ftemplate.json)

## Azure OpenAI

For Copilot functionality we leveraged Azure OpenAI Generative AI models, namely GPT-4 and GPT-4V (Vision). GPT-4 text-only model's Chat (or Completions) endpoint was used to set up an intelligent assistant for conversations.

While using GPT-4 model(s) quickly became ubiquotous amongst developers, we will just briefly touch upon technical aspects while using multi-modal [GPT-4V (Vision)](https://openai.com/research/gpt-4v-system-card) model. 

A novel way to leverage multi-modality (text and image(s)) is to use GPT-4V (Vision) based on "screenshots" of the screen taken from a live Unreal stream and sent to Generative AI to help interpret "what Am I looking at?" in a specific context. For that we automated the process of "taking a screenshot" on the screen using JavaScript so we can send it to GPT-4V (Vision) model in its base64 representation, the results received are spoken out load using Azure Speech SDK. Please find guidance [here](https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/gpt-with-vision) on how to use GPT-4V (Vision) multi-modal model in Azure OpenAI via Web API. Alternatively (if needed) you may leverage OpenAI GPT-4V (Vision) multi-modal model via Web API as described [here](https://platform.openai.com/docs/guides/vision).

## Important Considerations

Following are important considerations on how to prepare your Azure Subscription for deploying this sample:

* For leveraging Azure Cloud GPU Compute VMs your Azure Subscription will likely need to be enabled for deploying selected GPU-enabled SKUs of VMs (for example, NC or NV series) which may involve Azure Policies
* For successfull deployment of GPU-enabled VMs as a part of Azure Unreal Pixel Streaming Marketplace item you will likely need to request a quota increase for selected SKUs in [regions]() of your choice via Azure Support
* Please be cognizant of the fact that even after you have successfully deployed Azure Unreal Pixel Streaming Marketplace item in your Azure Subscription there still may be some subscription level policies that kick off afterwards and change initial configuration (for example, networking setup per corporate security), thus you may need to re-adjust some configurations later
* Please know that Azure VMs deployed by Azure Unreal Pixel Streaming Marketplace item inherit VM Extension(s) which may define behaviors like auto shut-down, etc. which you may want to adjust after initial deployment
* Please note that if connected to corporate network(s) your corporate networking configuration may block WebRTC traffic and be unable to do NAT (Network Address Translation), thus you may need to use VPN(s) as a workaround
* Please make sure to deploy Azure Unreal Pixel Streaming Marketplace item securely using HTTPS because Azure Speech SDK for JavaScript in the browser won't work over unsecure HTTP
* For issuing wildcard SSL certificate(s) for your secure deployment of Azure Unreal Pixel Streaming Marketplace item you may consider using Let's Encrypt [CertBot](https://certbot.eff.org/)
* For using Azure OpenAI Generative AI multi-modal models you may need to request access for your Azure Subscription [here](https://aka.ms/oai/access)
* For using OpenAI Generative AI multi-modal models via Web APIs you may need to upgrade to OpenAI Plus account with some funds available there

## Disclaimer

This code is provided "as is" without warranties to be used at your own risk.
