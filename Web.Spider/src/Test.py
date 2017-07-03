line = "ff6b384f70762b144c7d6c4c0a79467c.pdf\tAn introduction to Clifford algebras and spinors"

index = line.find('\t')
key = line[0: index]
extensionIndex = key.rfind('.')
extension = key[extensionIndex:]
value = line[index + 1 : ] + extension

print(key)
print(value)