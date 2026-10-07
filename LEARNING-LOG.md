# Learning Log

## L1.1 - Lab setup and cost control (started 6 Oct 2026)
- [x] Azure subscription (free) created
- [x] Budget alert email proven (Activity Log alert + action group; budget test button not supported on free trial)
- [x] Foundry project (ai-lab-project), chat-dev (gpt-5-mini) and embed-dev (text-embedding-3-small) deployed, 10K TPM each
- [x] First call works with no API key in code (labs/L1.1-first-call)
- [x] Repo created with README stating the course goal

Notes:
-
- Foundry resource: foundry-ai-lab-masood (eastus2), in rg-ai-lab. Role used: Foundry User (scope: the Foundry resource only).
- Role names changed: old "Azure AI User" is now "Foundry User" (checked with az role definition list).
- Budget has no test button on free trial. Proved the email with an Activity Log alert + action group.
- Guard layers against cost: TPM cap per deployment, budget alert, free-trial spending limit, no keys in code.
