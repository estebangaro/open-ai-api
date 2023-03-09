const PROXY_CONFIG = [
  {
    context: [
      "/openapi",
    ],
    target: "https://localhost:7055",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
