// CDlgSave.cpp: 구현 파일
//

#include "pch.h"
#include "MiniProject1_MFC.h"
#include "CDlgSave.h"
#include "afxdialogex.h"
#include "MiniProject1_MFCDlg.h";



// CDlgSave 대화 상자

IMPLEMENT_DYNAMIC(CDlgSave, CDialogEx)

CDlgSave::CDlgSave(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_DLG_SAVE, pParent)
{

}

CDlgSave::~CDlgSave()
{
}

void CDlgSave::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}


BEGIN_MESSAGE_MAP(CDlgSave, CDialogEx)
	ON_BN_CLICKED(IDOK, &CDlgSave::OnBnClickedOk)
	ON_BN_CLICKED(IDC_BT_NO, &CDlgSave::OnClickedBtNo)
	ON_BN_CLICKED(IDCANCEL, &CDlgSave::OnBnClickedCancel)
END_MESSAGE_MAP()


// CDlgSave 메시지 처리기


void CDlgSave::OnBnClickedOk()
{
	// TODO: 여기에 컨트롤 알림 처리기 코드를 추가합니다.
	CDialogEx::OnOK();
	state = 1;
}

void CDlgSave::OnClickedBtNo()
{
	state = 2;
	EndDialog(0);
}


void CDlgSave::OnBnClickedCancel()
{
	// TODO: 여기에 컨트롤 알림 처리기 코드를 추가합니다.
	state = 3;
	CDialogEx::OnCancel();
}
