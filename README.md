# RSA-AES Encryption with Hashing

This project is an encryption application that combines AES, RSA, and hashing algorithms to protect sensitive data and passwords. It is designed for developers who value high security in their projects.

## Features

- **AES Encryption**: Fast and secure symmetric key encryption for data.
- **RSA Encryption**: Public and private key encryption to securely protect the AES key.
- **Secure Hashing**: Irreversible password hashing using BCrypt.
- **Secure Memory Management**: Clears sensitive values from memory after use to prevent unauthorized access.

## Security Design

1. Encrypts the user-entered password using AES.
2. Encrypts the AES key securely using RSA.
3. Hashes the decrypted password with BCrypt for secure storage.
4. Clears keys and sensitive values from memory after processing.

## Project Structure

```plaintext
rsa_aes_encryption/
├── src              # Main application code
├── README.md        # Project documentation
└── LICENSE          # License file
```

to understand how it works see : https://github.com/Asma-Jamshidian2007/Cryptex/blob/main/src/Theoretical%20and%20Mathematical%20Foundations.md

## How It Works

1. The user enters a password.
2. The password is encrypted using AES.
3. The AES key is securely encrypted with RSA.
4. The password is decrypted and hashed.
5. Keys and sensitive values are cleared from memory.

## Prerequisites

- **Platform**: .NET Framework or .NET Core
- **Libraries**:
  - `System.Security.Cryptography`
  - `BCrypt.Net`

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

This application is designed for developers seeking a simple yet secure solution for data encryption.
