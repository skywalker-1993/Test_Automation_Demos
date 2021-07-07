import csv

csv_file = 'test_input.csv'
csv_to_write = 'output_res.csv'

users_dict = {}

# METHOD 1
'''with open(csv_file, mode='r') as csvfile_read, open(csv_to_write, mode='wb') as csvfile_write:
    reader = csv.reader(csvfile_read, delimiter=',')
    for i, row in enumerate(reader):
        if i > 0:
            users_dict.update({row[0]: row[1]})
            csvfile_write.write('No errors found!\n'.encode())

print(users_dict)'''

# METHOD 2
with open(csv_file, mode='r') as csvfile_read, open(csv_to_write, mode='w') as csvfile_write:
    i = 0
    content = csvfile_read.readline()
    while content:
        if i > 0:
            users_dict.update({content.split(',')[0].strip(): content.split(',')[1].strip()})
            csvfile_write.write('No errors found!\n')
        content = csvfile_read.readline()
        i += 1

print(users_dict)

lst = ['hi', 'hello', 'goodbye', 'bye', 'adios', 'ciao']
'''# for i in range(len(lst)):
for i in lst:
    # print(lst[i])
    print(i)
    lst.append('---')'''

'''i = 0
while i < len(lst):
    print(lst[i])
    i += 1
    lst.append('---')'''
