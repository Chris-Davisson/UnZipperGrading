   M S B A M L   `   `   `  ����G  CUnZipGrading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:UnZipGradingUnZipGrading  5   	       UnZipGrading.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:UnZipGrading     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��
source_lbl��5
      $��Source��6"   $
��Left=�63   $��	10,10,0,0q�6N   $	��Top=�6a   $��91��6y   $��20(�6�   �� 5   
   -   5        $��dest_lbl��5      $��Destination��6    $
��Left=�66   $��
10,151,0,0q�6Q   $	��Top=�6e   $	��120��6}   $��20(�6�   �� 5   
   -   5         ��Name$ 
output_lbl��5      $��Output��6$   $
��Left=�65   $��	374,5,0,0q�6P   $	��Top=�6c   $��91��6{   $��20(�6�   �� 5   
   -   5        $��
source_txt��5      $
��Left=�6$   $��	10,52,0,0q�6?    �� TextWrapping$
 Wrap=�6R   $	��Top=�5      $	��359��60   $��72��6<    �� 	IsEnabled . $#��Enter Absolute Source path...��6�   6�   �� 5   
   -   5        $��dest_txt��5      $
��Left=�6"   $��
10,193,0,0q�6=   $
 Wrap=�6Q   $(��"Enter Absolute Destination path...��6e   $	��Top=�5       J� RenderTransformOrigin$ -0.286,-1.098&�60   $	��359��6V   $��72��6b    . 6�   �� 5   
   -   5        $��
output_txt��5      $
��Left=�6$   $��
374,47,0,0q�6?   $
 Wrap=�6T   $	��...��6h   $	��Top=�5      $	��386��60   $	��340��6<   �� 5   
   -   5        $��	start_btn��5      $��Do The Thing!��6"   $
��Left=�6:   $��
88,300,0,0q�6U   $	��Top=�6i   $��75��6�   6�   5      5      