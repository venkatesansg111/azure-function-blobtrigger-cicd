# azure-function-blobtrigger-cicd

# Event-Driven Azure Function App (.NET 6)

This repository contains a sample **Azure Function App** built using **.NET 6**, triggered by **Azure Blob Storage**, and deployed to **Azure using GitHub Actions CI/CD pipeline**.

## 📌 Project Objective

- Learn and demonstrate how to build a **.NET-based event-driven application** using Azure Functions.
- Set up an **automated CI/CD pipeline** with GitHub Actions to deploy the Function App to Azure.
- Gain hands-on experience with **Azure Blob Storage Triggers**, `.NET Worker SDK`, and deployment workflows.

---

## 🚀 Technologies Used

- [.NET 6](https://dotnet.microsoft.com/en-us/)
- [Azure Functions](https://learn.microsoft.com/en-us/azure/azure-functions/)
- [Azure Blob Storage](https://learn.microsoft.com/en-us/azure/storage/blobs/)
- [GitHub Actions](https://docs.github.com/en/actions)
- [Azure Function Deploy Action](https://github.com/Azure/functions-action)

---

## 📂 Function App Overview

This function triggers when a new blob is uploaded to a specific container in Azure Storage.

### 🔧 BlobTriggerFunction.cs

```csharp
[Function("BlobTriggerFunction")]
public void Run(
    [BlobTrigger("samples-workitems/{name}", Connection = "AzureWebJobsStorage")] Stream blobStream,
    string name)
{
    _logger.LogInformation($"Blob processed: Name = {name}, Size = {blobStream.Length} Bytes");
}
