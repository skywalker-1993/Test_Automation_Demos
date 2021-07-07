def retrieve_result_count(txt):
    new_txt_list = txt.split(' ')
    ind = new_txt_list.index('results')
    count = int(''.join(new_txt_list[ind-1].strip().split(',')))
    print(count)
    return count