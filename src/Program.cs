using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using BCrypt.Net;

    namespace rsa_aes_encryption
    {
        class Program
        {
            static void Main()
            {
            try {
                Console.Write("Enter your password: ");
                string entered_Password = Console.ReadLine();

                //  creating an object of type RSA
                using (RSA rsa = RSA.Create())
                {
                    // retrieving the parameters, which include the private and public keys, from the RSA object and prepare them for reuse.
                    RSAParameters rsa_Parameters = rsa.ExportParameters(true);

                    // creating an object of type AES.
                    using (Aes aes = Aes.Create())
                    {
                        // randomly generating the key and initialization vector (IV) for the AES object.
                        aes.GenerateKey();
                        aes.GenerateIV();

                        //  encrypting the AES key using RSA encryption.
                        byte[] encrypted_AES_Key = rsa.Encrypt(aes.Key, RSAEncryptionPadding.Pkcs1);

                        //  encrypting the password using the encrypt_Password function.
                        byte[] encrypted_Password = encryption(entered_Password, aes.Key, aes.IV);

                        // converting the result to Base64 for easy readability and displaying it.
                        Console.WriteLine($"Encrypted password: {Convert.ToBase64String(encrypted_Password)}");

                        // clearing the key and IV after use to remove them from memory and to prevent unauthorized access.
                        Array.Clear(aes.Key, 0, aes.Key.Length);
                        Array.Clear(aes.IV, 0, aes.IV.Length);

                        // decrypting the AES key so that we can use it to access the encrypted information.
                        byte[] decrypted_AES_Key = rsa.Decrypt(encrypted_AES_Key, RSAEncryptionPadding.Pkcs1);

                        // decrypting the password using the decrypt_Password function here.
                        string decrypted_Password = decryption(encrypted_Password, decrypted_AES_Key, aes.IV);

                        Console.WriteLine($"Decrypted password: {decrypted_Password}");

                        // hashing the decrypted password with .
                        string hashed_Password = BCrypt.Net.BCrypt.HashPassword(decrypted_Password);

                        Console.WriteLine($"Hashed Password: {hashed_Password}");

                        // clearing the original password from memory and using the hash instead
                        Array.Clear(Encoding.UTF8.GetBytes(entered_Password), 0, entered_Password.Length);

                    }
                }
            }       
            
            catch
            {
                Console.WriteLine("An unexpected error occurred. Please try again.");
            }

        }
        // in this program, all functions are defined as private to provide enhanced security.
        // creating a method for encrypting the password that includes the input parameters: IV (initialization vector) and plain_Password.
        private static byte[] encryption(string plain_Password, byte[] Key, byte[] IV)
            {
                // checking if plain_Password is null or has a length of zero
                // if it is null or empty, throw an ArgumentNullException
                if (plain_Password == null || plain_Password.Length <= 0)
                    throw new ArgumentNullException("plain_Password");

                // checking if Key is null or has a length of zero
                // if it is null or empty, throw an ArgumentNullException
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");

                // checking if IV is null or has a length of zero
                // if it is null or empty, throw an ArgumentNullException
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");

                byte[] encrypted;

                // creating an object of type AES once again.
                // redefining the object promotes the self-sufficiency of the function, meaning that the function
                // supplies its own required resources and does not depend on external objects, among other reasons.
                using (Aes aesAlg = Aes.Create())
                {
                    // set the key and initialization vector (IV) for the AES object.
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;

                    // creating an object using CreateDecryptor for encryption.
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    // use MemoryStream for the encrypted data in memory.
                    using (MemoryStream memoryStream_Encrypt = new MemoryStream())
                    {
                        // using memoryStreamEncrypt as the storage for encrypted information and specify the encryptor as the encryption algorithm.
                        using (CryptoStream cryptoStream_Encrypt = new CryptoStream(memoryStream_Encrypt, encryptor, CryptoStreamMode.Write))
                        {
                            //  using StreamWriter to write information to the CryptoStream.
                            using (StreamWriter streamWriter_Encrypt = new StreamWriter(cryptoStream_Encrypt))
                            {
                                //use StreamWriter to write plain_Password to the CryptoStream.
                                streamWriter_Encrypt.Write(plain_Password);
                            }

                            // converting the encrypted data to array using memoryStream_Encrypt.ToArray().
                            encrypted = memoryStream_Encrypt.ToArray();
                        }
                    }
                }
                // returning the encrypted byte array.
                return encrypted;
            }
           private static string decryption(byte[] cipher_Password, byte[] Key, byte[] IV)
            {
                // checking if cipher_Password is null or has a length of zero
                // if it is null or empty, throw an ArgumentNullException
                if (cipher_Password == null || cipher_Password.Length <= 0)
                    throw new ArgumentNullException("cipher_Password");

                // checking if Key is null or has a length of zero
                // if it is null or empty, throw an ArgumentNullException
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");

                // checking if IV is null or has a length of zero
                // if it is null or empty, throw an ArgumentNullException
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");


                string plain_Password;
                //  creating an object using CreateDecryptor for decryption.
                using (Aes aes_Alg = Aes.Create())
                {
                    // setting the key and initialization vector (IV) for the AES object.
                    aes_Alg.Key = Key;
                    aes_Alg.IV = IV;

                    // creating an object using CreateDecryptor for decryption.
                    ICryptoTransform decryptor = aes_Alg.CreateDecryptor(aes_Alg.Key, aes_Alg.IV);

                    // using MemoryStream to read the encrypted data.
                    using (MemoryStream memoryStream_Decrypt = new MemoryStream(cipher_Password))
                    {
                        //  using memoryStream_Decrypt for decrypting the data within CryptoStream.
                        using (CryptoStream cryptoStream_Decrypt = new CryptoStream(memoryStream_Decrypt, decryptor, CryptoStreamMode.Read))
                        {
                            //The StreamReader reads the data and returns it as the original text or, more accurately,
                            //the original data from cryptoStream_Decrypt, thus providing the decrypted information.
                            using (StreamReader streamReader_Decrypt = new StreamReader(cryptoStream_Decrypt))
                            {
                                // reading all data from CryptoStream.
                                plain_Password = streamReader_Decrypt.ReadToEnd();
                            }
                        }
                    }
                }
                // returning them as string.
                return plain_Password;

            }
        }
    }


