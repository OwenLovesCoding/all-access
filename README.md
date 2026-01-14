🌐 URL Shortener API
Transform long, messy URLs into clean, memorable links with this sleek .NET 10 API powered by Rebrandly.

✨ Features That Spark Joy
🔗 Smart URL Shortening - Convert lengthy URLs into brandable short links

🛡️ Security First - API keys safely tucked away using .NET User Secrets

⚡ Optimized Performance - Built with HttpClientFactory for efficient HTTP connections

📊 Professional Results - Get detailed analytics-ready shortened URLs

🚀 Quick Start
Prerequisites
> .NET 10 SDK

A Rebrandly account (free tier available!)

Installation Magic
Clone & Enter

bash
git clone https://github.com/owenlovescoding/all-access.git
cd all-access

Secret Sauce Setup

bash
dotnet user-secrets init
dotnet user-secrets set "Rebrandly:ApiKey" "your-actual-api-key"
dotnet user-secrets set "Rebrandly:WorkSpaceId" "your-workspace-id"
Launch Time

bash
dotnet run

🎮 How to Use
Shorten a URL (The Fun Part)
Request:

http
POST https://localhost:7081/link/send-link
Content-Type: application/json

{
  "sourceUrl": "https://www.youtube.com/watch?v=dQw4w9WgXcQ"
}
Response:

string
rebrand.ly/q3czwj7

🏗️ Architecture Highlights
🎯 Smart Design Choices
HttpClientFactory - No more port exhaustion worries!

Dependency Injection - Clean, testable code structure

Async All the Way - Responsive API that won't block

Configuration Patterns - Easy environment switching

🔐 Security Superpowers
Your Rebrandly API key is never hard-coded, thanks to:

.NET User Secrets for local development

Environment variables for production

Azure Key Vault ready (just add a few lines!)

Via cURL (For terminal wizards)

bash
curl -X POST "https://localhost:7081/link/send-link" \
     -H "Content-Type: application/json" \
     -d '{"SourceUrl":"https://your-long-url-here.com"}'
📈 Why This Rocks
✅ Zero configuration headaches - User secrets keep your keys safe locally
✅ Production ready - Swap to environment variables in one line
✅ Enterprise patterns - Built with scalability in mind
✅ Fun to use - Because APIs should bring joy!

🛣️ Where to go from here?
QR Code generation for short URLs

Custom alias support (rbnd.ly/your-brand)

Click analytics dashboard

Bulk URL shortening

Rate limiting and analytics

🤝 Contributing
Found a bug? Have a feature idea? I'd love your input

HttpClientFactory Best Practices

🎯 Pro Tips
💡 Custom Domains: Upgrade your Rebrandly account to use your own domain!
💡 Analytics: Check your Rebrandly dashboard for click analytics
💡 Branding: Customize your short links with emojis in Rebrandly Pro

Built with ❤️
Turn those endless URLs into beautiful, shareable links!

<div align="center">
⭐ Like this project? Give it a star! ⭐
https://img.shields.io/github/stars/owenlovescoding/all-access?style=social

Shorten responsibly. Share joyfully. 🌟

</div>
