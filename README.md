# RSA-AES Encryption with Hashing

This project is a secure encryption application that combines AES, RSA, and hashing algorithms to protect sensitive data and passwords. It is designed for developers who prioritize high security in their projects.

## Features

- **AES Encryption:** Fast and secure symmetric encryption for protecting data.
- **RSA Encryption:** Asymmetric encryption used to securely encrypt the AES key.
- **Secure Hashing:** Irreversible password hashing using BCrypt.
- **Secure Memory Management:** Sensitive keys and data are cleared from memory immediately after use to prevent unauthorized access.

## Security Design

1. The user inputs a password.  
2. The password is encrypted using AES.  
3. The AES key is encrypted securely using RSA.  
4. The decrypted password is hashed with BCrypt for secure storage.  
5. All sensitive keys and data are cleared from memory after processing.

## Project Structure


rsa_aes_encryption/
├── src # Main application source code
├── README.md # Project documentation
└── LICENSE # License information

## Theoretical and Mathematical Foundations

To better understand the underlying cryptographic principles, see the detailed documentation [here](https://github.com/Asma-Jamshidian2007/Cryptex/blob/main/src/Theoretical%20and%20Mathematical%20Foundations.md).

## How It Works

1. User inputs a password.  
2. Password is encrypted using AES.  
3. AES key is encrypted with RSA for secure key exchange.  
4. Password is decrypted and hashed using BCrypt.  
5. Keys and sensitive data are securely cleared from memory.

## Prerequisites

- **Platform:** .NET Framework or .NET Core  
- **Dependencies:**  
  - `System.Security.Cryptography`  
  - `BCrypt.Net`  

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

This application offers developers a straightforward yet secure solution for data encryption and password protection.

---

If you want a Persian version or any other changes, just ask!
