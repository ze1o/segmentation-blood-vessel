addpath(genpath('./data'));
addpath(genpath('./functions'));
clear
clc
close all
se=strel('line',12,90);
%% Read file
im=imread('source.tif');
bw_mask=imread('mask.tif');
bw_mask=logical(bw_mask);                                                   %Chuyen du lieu anh mask qua dang logic 1 và 0, khac 0 -> 1,  bang 0 -> 0
                                                                            %Anh mask chi co 2 mau, trang va den. Vi trang 255 > 0, den 0 = 0 => mau sac anh mask ko thay doi gi (nhung gia tri tung pixel thi thay doi)
%% Pre-progressing
im=im(:,:,2);                                                               %So hang - so cot - so thu tu kenh (1-2-3 tuong ung Red-Green-Blue). - Dong code nay chi co tac dung vs anh mat (Vi anh mat co mau)
% figure,imshow(im);title('imcomplement');
im=mat2gray(im).*mat2gray(bw_mask);                                         %Phep nhan element by element cua 2 ma tran grayscale (xam). Chuyen ve anh xam de xac dinh muc do xam, so sanh do xam cua mach voi nen
% figure,imshow(im);title('imcomplement');                                                                            %Anh goc la 3 mau nen can chuyen ve mot mau
                                                                            %Ket qua nhan duoc la anh mask se che di nhung doi tuong ko can thiet (vi mau den la so 0, 0 nhan cho bat cu so nao cung la 0)
                                                                            %Vung mau trang la so 1 -> giu nguyen gia tri
im=imcomplement(im);                                                        %Dao nghich do tuong phan - vi nhung buoc sau nay minh se xet nhung diem co do sang cao se thuoc mach mau
% figure,imshow(im);title('imcomplement');
im=im2double(im);                                                           %Dam bao anh sau qua trinh tien xu ly la mot ma tran kieu double

%% Progressing
DEG_NUM=12;                                                                 %So lan quay SE                                                                                                                 
LEN_c=10;                                                                   %Chieu rong mach mau
LEN_o=20;                                                                   %Chieu rong lon hon mach mau - dung de xoa mach => tao anh nen
LEN_diff=17;                                                                %
ic1=reconstruction_by_dilation(im,LEN_c,DEG_NUM);                           %Tang cuong do sang cua mach mau
% figure,imshow(ic1);title('reconstruction_by_dilation');
io1=min_openings(im,LEN_o,20);                                              %Xoa mach mau, tao nen
% figure,imshow(io1);title('min openning 20');
iv=mat2gray(ic1-io1);                                                       %Thuc hien phep tru de thu duoc anh co mach mau ro hon
% figure,imshow(iv);title('iv');
imDiff=smooth_cross_section(iv,LEN_diff,LEN_c);                             %Lam min nen, vien va tang cuong mach mau
% figure,imshow(imDiff);title('imDiff');
imL=reconstruction_by_dilation(imDiff,LEN_c,DEG_NUM);                       %Xoa nhieu tao ra boi Gaussian, tang cuong do sang.
% figure,imshow(imL);title('imL');
imF=reconstruction_by_erosion(imL,LEN_c,DEG_NUM);                           %Lap day cac lo trong ben trong mach mau
% figure,imshow(imF);title('imF');
%% Hysteresis Threshold
TH_LOW=12;
TH_HIGH=33;
min_obj=180;
min_hole=10;
mask=im2bw(imF,TH_LOW/255);
marker=im2bw(imF,TH_HIGH/255);
bw_result=imreconstruct(marker,mask);
%figure,imshow(bw_result);title('before');
%% Some extra cleaning on the result.
bw_result=bw_result& bw_mask;
bw_result = clear_bw(bw_result, min_obj, min_hole);
% figure,imshow(bw_result);title('result');
imwrite(bw_result,'data\result.tif');