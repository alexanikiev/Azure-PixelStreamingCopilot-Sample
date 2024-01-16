# Azure-PixelStreamingCopilot-Sample

Welcome to the Azure Pixel Streaming Copilot Sample repository on GitHub. This code base written with the help of [ChatGPT](https://chat.openai.com/) and [GitHub Copilot](https://github.com/github/copilot) serves as a reference implementation of an Unreal 4.x/5.x Pixel Streaming Copilot Immersive Experience App in Microsoft Azure Cloud based on Epic Games' Unreal Pixel Streaming Technology. To gracefully and intuitively bring in Copilot capabilities it integrates with Azure Speech SDK, Azure OpenAI Generative AI models and OpenAI Generative AI models, including multi-modal GPT-4V (GPT-4 with Vision) model. It's a great example of modern innovation leveraging robust Microsoft Azure Cloud capabilities for Cloud-based GPU Compute, best practices for building full-stack Azure Cloud solution architectures for modern web applications, and streaming high definition and high quality interactive 3D content via Epic Games' Unreal Pixel Streaming Technology at real-time on-demand in the web browser of your choice (Microsoft Edge, Google Chrome, Apple Safari, etc.) on the device of your choice (PC/Mac, tablet/iPad, phone/iPhone, etc.) securely over Internet.

## Motivation

Make everything as simple as possible, but not simpler.

## Getting Started

This Unreal Engine sample is intended for Unreal Engine apps packaged for Windows platform. Once packaged Unreal Engine app zip archive gets placed in Azure Blob Storage container, from which it is referenced during Azure Unreal Pixel Streaming Marketplace item deployment. This deployment results in creation of the necessary IaaS Azure Cloud infrastructure which consist of Azure Traffic Manager, Matchmaking Server(s) VMs, Signalling Server(s) VM Scale sets, etc. to support a desired number of streams in a multi-region deployment. Generative AI capabilities of Azure Open AI and optionally OpenAI are used along with Azure Speech SDK for implementing a Copilot which can hear, speak, see and interact with You in a meaningful way.

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

Please note that you will only need to install Unreal Engine 5.3 or later if you plan to create your own customizations to Unreal Engine package using Unreal Engine Blueprints, otherwise you are welcome to use already pre-packaged customized Unreal Engine Third Person Template Project [here](). This sample takes advantage of Azure Marketplace Unreal Pixel Streaming item [here](https://portal.azure.com/#create/epicgames.unreal-pixel-streamingunreal-pixel-streaming) for deploying multi-region deployment of Azure Unreal Pixel Streaming. Please see Solution Architecture diagram below for more details.

## Solution Architecture

![Solution Architecture](https://github.com/alexanikiev/Azure-PixelStreamingCopilot-Sample/docs/images/uepixelbackend-copilot-dark.png)

## Installing

TBD

Unreal Engine Blueprints

Azure Blob Storage

Azure Function Host

Azure Key Vault References

## Cloud Deployment

TBD

## Azure OpenAI

TBD

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
