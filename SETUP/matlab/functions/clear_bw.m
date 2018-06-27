function result = clear_bw(bw, min_obj, min_hole)
%xoa cac vi tri khong phai la mach mau dung anh mark
if min_obj > 0
    result = bwareaopen(bw, ceil(min_obj));                               
else
    result = bw;
end
% fill small holes
if min_hole > 0
    result = ~bwareaopen(~result, floor(min_hole));                         %Khi doi nguoc l?i, nhung lo nho se co mau trang, mach mau den. 
                                                                            %Khi xoa thi lo nho -> mau den nen khi doi l?i 1 lan nua, cac lo nho nay se cung mau voi mach
end