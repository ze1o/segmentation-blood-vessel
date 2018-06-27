function imDiff=smooth_cross_section(imV,LEN_diff,DEG_NUM)
%
%LEN==>LEN_diff
if nargin<3 || isempty(LEN_diff)
    LEN_diff=7;
end
if nargin<3 || isempty(DEG_NUM)
    DEG_NUM=12;
end
imV_c=imcomplement(imV);                                                    %Dao nghich do tuong phan
G1=fspecial('gaussian',[1 LEN_diff],0.5);%fspecial('gaussian',hsize,sigma)  %Tra ve mot bo loc LowPass Gaussian có ??i x?ng quay hsize v?i ?? l?ch chu?n sigma (tích c?c)
G2=fspecial('log',[1 LEN_diff],1.75);                                       %Tr? v? m?t b? l?c Laplace c?a b? l?c Gaussian hsize v?i kích th??c chu?n v?i ?? l?ch chu?n sigma (tích c?c).

imd=cell(12,1);
for i=1:12
    DEG=(i-1)*15;
    se1=makeLineKernel(LEN_diff,DEG,G1);
    se2=makeLineKernel(LEN_diff,DEG+90,G2);

    temp=imfilter(double(imV_c),se1,0,'same','conv');                       %0 - ben ngoai bound -> set = 0, same - cung kich thuoc, conv - su dung tich chap convolution
%     figure,imshow(temp);title('temp');
    imd{i}=imfilter(mat2gray(temp),se2,0,'same','conv');
    imd{i}( imd{i}<0)=0;
%     figure,imshow(imd{i});title('imd{i}');
end
imDiff=imd{1};
for i=2:length(imd)
    imDiff=max(imDiff,imd{i});% eq. (3.5)
end
imDiff=mat2gray(imDiff);