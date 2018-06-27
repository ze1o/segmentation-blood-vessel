function imC2=reconstruction_by_dilation(im,LEN,DEG_NUM)
%
% $$I_1=R_{I_o}\left (max\left\{\gamma_{B_i} (I_o)\right\}\right), & i=1,...,12$$ 
% INPUT: 
%     IM (blood image)
%     LEN (defualt: 11)
%     DEG_NUM (default:12)
% OUTPUT: 
%     imC2 
if nargin<3 || isempty(LEN)                                                 %Number of function input arguments - nargin
    LEN=11;
end
if nargin<3 || isempty(DEG_NUM)
    DEG_NUM=12;
end

imo=cell(DEG_NUM,1);                                                        %Tao mang 12 ma tran voi gia tri rong
                                                                            %Tien hanh quay SE 12 lan, moi lan cac goc chenh nhau 15 do
                                                                            %Moi lan quay se thuc hien opening de giu lai cac phan tu tren anh thoa SE, xoa bo cac phan tu nho v� nhieu
for i=1:DEG_NUM
    DEG=(i-1)*((360/DEG_NUM)/2);
    se=strel('line',LEN,DEG);
    imo{i}=imopen(im,se);
end

imC=imo{1};                                                                 %Anh co tong gia tri mau lon nhat se la anh chua nhieu phan tu thoa SE nhat => Mach dc giu nhieu nhat
for i=2:length(imo)
    imC=max(imC,imo{i});% eq. (3.1)
end

imC2=imreconstruct(imC,im); % eq. (3.2)                                     %Khoi phuc cac mach mau nho bi xoa di, chi co nhung mach mau nho moi dc khoi phuc vi co lien ket vs mach mau chinh
imC2=mat2gray(imC2);