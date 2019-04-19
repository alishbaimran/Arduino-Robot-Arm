% Robotic Arm Control via MATLAB and Arduino

% Note: Make sure to clear all variables in the workspace before running
% this code
function varargout = RoboticArmControl2(varargin)
% ROBOTICARMCONTROL2 MATLAB code for RoboticArmControl2.fig
%      ROBOTICARMCONTROL2, by itself, creates a new ROBOTICARMCONTROL2 or raises the existing
%      singleton*.
%
%      H = ROBOTICARMCONTROL2 returns the handle to a new ROBOTICARMCONTROL2 or the handle to
%      the existing singleton*.
%
%      ROBOTICARMCONTROL2('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in ROBOTICARMCONTROL2.M with the given input arguments.
%
%      ROBOTICARMCONTROL2('Property','Value',...) creates a new ROBOTICARMCONTROL2 or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before RoboticArmControl2_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to RoboticArmControl2_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help RoboticArmControl2

% Last Modified by GUIDE v2.5 26-Apr-2018 23:38:50

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @RoboticArmControl2_OpeningFcn, ...
                   'gui_OutputFcn',  @RoboticArmControl2_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end
% End initialization code - DO NOT EDIT


% --- Executes just before RoboticArmControl2 is made visible.
function RoboticArmControl2_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to RoboticArmControl2 (see VARARGIN)

%---------Reset Static Text boxes----------------------------------%
set(handles.text5, 'String', '90');
set(handles.text6, 'String', '90');
set(handles.text7, 'String', '90');
set(handles.text8, 'String', '90');

% Choose default command line output for RoboticArmControl2
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes RoboticArmControl2 wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = RoboticArmControl2_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;

clear all;
global a s1 s2 s3 s4 record data play;
record  = 0;
play = 0;
data = []; 

a=arduino('com4','uno');
s1=servo(a,'D3'); %servo1 for base
s2=servo(a,'D5'); %servo2 for shoulder
s3=servo(a,'D6'); %servo 3 for elbow
s4=servo(a,'D9'); %servo 4 for gripper
writePosition(s1,0.5);
pause(1);
writePosition(s2,0.5);
pause(1);
writePosition(s3,0.5);
pause(1);
writePosition(s4,0.5);
pause(1);


%SLIDER1------------------INITIALIZATION------------------------%

% --- Executes during object creation, after setting all properties.
function slider1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end

%SLIDER1-Base-----------------CALLBACK------------------------------%
% --- Executes on slider movement.
function slider1_Callback(hObject, eventdata, handles)
% hObject    handle to slider1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

global a;
global s1;
pos=get(hObject,'Value'); %same as pos=get(handles.slider1,'Value');
pos1=pos/180;
pos1=1-pos1; %For position inversion
writePosition(s1,pos1);
set(handles.text5,'String',num2str(int16(pos)));
global data record
if record == 1
    data = [data; 1 pos1];
end

% Hints: get(hObject,'Value') returns position of slider
%        get(hObject,'Min') and get(hObject,'Max') to determine range of slider



%SLIDER2------------------INITIALIZATION------------------------%
% --- Executes during object creation, after setting all properties.
function slider2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end


%SLIDER2-Shoulder-----------------CALLBACK------------------------------%
% --- Executes on slider movement.
function slider2_Callback(hObject, eventdata, handles)
% hObject    handle to slider2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

global a;
global s2;
pos=get(hObject,'Value'); %same as pos=get(handles.slider1,'Value');
pos2=pos/180;
pos2=1-pos2; %For position inversion
writePosition(s2,pos2);
set(handles.text6,'String',num2str(int16(pos)));
global data record
if record == 1
    data = [data; 2 pos2];
end

% Hints: get(hObject,'Value') returns position of slider
%        get(hObject,'Min') and get(hObject,'Max') to determine range of slider



%SLIDER3------------------INITIALIZATION------------------------%
% --- Executes during object creation, after setting all properties.
function slider3_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end

%SLIDER3-Elbow-----------------CALLBACK------------------------------%
% --- Executes on slider movement.
function slider3_Callback(hObject, eventdata, handles)
% hObject    handle to slider3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
global a;
global s3;
pos=get(hObject,'Value'); %same as pos=get(handles.slider1,'Value');
pos3=pos/180;
writePosition(s3,pos3);
set(handles.text7,'String',num2str(int16(pos)));
global data record
if record == 1
    data = [data; 3 pos3];
end

% Hints: get(hObject,'Value') returns position of slider
%        get(hObject,'Min') and get(hObject,'Max') to determine range of slider



%SLIDER4------------------INITIALIZATION------------------------%
% --- Executes during object creation, after setting all properties.
function slider4_CreateFcn(hObject, eventdata, handles)
% hObject    handle to slider4 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: slider controls usually have a light gray background.
if isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor',[.9 .9 .9]);
end




%SLIDER4------------------CALLBACK------------------------------%
% --- Executes on slider movement.
function slider4_Callback(hObject, eventdata, handles)
% hObject    handle to slider4 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

global a;
global s4;
pos=get(hObject,'Value'); %same as pos=get(handles.slider1,'Value');
pos4=pos/180;
writePosition(s4,pos4);
set(handles.text8,'String',num2str(int16(pos)));
global data record
if record == 1
    data = [data; 4 pos4];
end
% Hints: get(hObject,'Value') returns position of slider
%        get(hObject,'Min') and get(hObject,'Max') to determine range of slider



%--------------------------------------------------------------%
%EDIT TEXTBOX



function edit1_Callback(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of edit1 as text
%        str2double(get(hObject,'String')) returns contents of edit1 as a double


% --- Executes during object creation, after setting all properties.
function edit1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


function edit2_Callback(hObject, eventdata, handles)
% hObject    handle to edit2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of edit2 as text
%        str2double(get(hObject,'String')) returns contents of edit2 as a double


% --- Executes during object creation, after setting all properties.
function edit2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end



function edit3_Callback(hObject, eventdata, handles)
% hObject    handle to edit3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of edit3 as text
%        str2double(get(hObject,'String')) returns contents of edit3 as a double


% --- Executes during object creation, after setting all properties.
function edit3_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


function edit4_Callback(hObject, eventdata, handles)
% hObject    handle to edit4 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)



% Hints: get(hObject,'String') returns contents of edit4 as text
%        str2double(get(hObject,'String')) returns contents of edit4 as a double


% --- Executes during object creation, after setting all properties.
function edit4_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit4 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on button press in Reset.
function Reset_Callback(hObject, eventdata, handles)
% hObject    handle to Reset (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
%set(handles.answer_staticText,'String',c);
set(handles.slider4,'Value', 90)
set(handles.slider3,'Value', 90)
set(handles.slider2,'Value', 90)
set(handles.slider1,'Value', 90)
set(handles.text5,'String', '90')
set(handles.text6,'String', '90')
set(handles.text7,'String', '90')
set(handles.text8,'String', '90')
global record data play
record = 0;
data = [];
play = 0;

% --- Ex5ecutes during object creation, after setting all properties.
function text1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to text1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called


% --- Executes during object creation, after setting all properties.
function text2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to text2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called


% --- Executes on button press in pushbutton2.
function pushbutton2_Callback(hObject, eventdata, handles)
% hObject    handle to pushbutton2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
global record data play
if record == 1
        set(handles.pushbutton2,'BackgroundColor','white');
        play = 1;
        record = 0;
elseif record == 0      
        %recording starts
        record = 1;
        data = [];
        set(handles.pushbutton2,'BackgroundColor', 'green');
end


% --- Executes on button press in pushbutton3.
function pushbutton3_Callback(hObject, eventdata, handles)
% hObject    handle to pushbutton3 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
global s1 s2 s3 s4 play data
if play == 0
        errordlg('Robotic arm is busy','Record Null');  
elseif play == 1
    set(handles.pushbutton3,'BackgroundColor', 'green');
    writePosition(s1, 0.5);
    pause(1);
    writePosition(s2, 0.5);
    pause(1);
    writePosition(s3, 0.5);
    pause(1);
    writePosition(s4, 0.5);
    pause(1);
    [m,n] = size(data);
    for i=1:m
        if data(i,1) == 1
            writePosition(s1,data(i,2))
            pause(0.5)
        elseif data(i,1) == 2
            writePosition(s2,data(i,2))
            pause(0.5)
        elseif data(i,1) == 3
            writePosition(s3,data(i,2))
            pause(0.5)
        elseif data(i,1) == 4
            writePosition(s4,data(i,2))
            pause(0.5)
        end
    end
    set(handles.pushbutton3,'BackgroundColor', 'white');
    
end


% --- Executes during object creation, after setting all properties.
function pushbutton2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to pushbutton2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called


% --- Executes during object creation, after setting all properties.
function pushbutton3_CreateFcn(hObject, eventdata, handles)
% hObject    handle to pushbutton2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called
